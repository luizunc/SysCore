using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SysCore
{
    public partial class SysCore_Form : Form
    {
        private PerformanceCounter statuscpu;
        private PerformanceCounter statusdisk;
        private PerformanceCounter statusdiskRead;
        private PerformanceCounter statusdiskWrite;

        [DllImport("gdi32.dll")]
        private static extern IntPtr CreateDC(string lpszDriver, string lpszDevice, string lpszOutput, IntPtr lpInitData);
        [DllImport("gdi32.dll")]
        private static extern bool DeleteDC(IntPtr hdc);
        [DllImport("dxgi.dll", SetLastError = true)]
        private static extern int CreateDXGIFactory(ref Guid riid, out IntPtr ppFactory);

        // --- D3DKMTQueryStatistics Structures and P/Invoke ---
        public enum D3DKMT_QUERYSTATISTICS_TYPE
        {
            D3DKMT_QUERYSTATISTICS_ADAPTER = 0,
            D3DKMT_QUERYSTATISTICS_PROCESS = 1,
            D3DKMT_QUERYSTATISTICS_SEGMENT = 2,
            D3DKMT_QUERYSTATISTICS_PROCESS_SEGMENT = 3,
            D3DKMT_QUERYSTATISTICS_NODE = 4,
            D3DKMT_QUERYSTATISTICS_PROCESS_NODE = 5,
            D3DKMT_QUERYSTATISTICS_VIDPNSOURCE = 6,
            D3DKMT_QUERYSTATISTICS_PROCESS_VIDPNSOURCE = 7
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct D3DKMT_QUERYSTATISTICS
        {
            public D3DKMT_QUERYSTATISTICS_TYPE Type;
            public uint AdapterLuidLowPart;
            public uint AdapterLuidHighPart;
            public uint NodeId;
            public uint PhysicalAdapterIndex;
            // O restante dos campos não será usado neste exemplo simplificado
        }

        [DllImport("gdi32.dll", SetLastError = true)]
        public static extern int D3DKMTQueryStatistics(ref D3DKMT_QUERYSTATISTICS stats);
        // --- Fim das estruturas ---

        public SysCore_Form()
        {
            InitializeComponent();
            info_cpu();
            
            // Exibir nome da GPU (integrada ou dedicada)
            try
            {
                var searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController");
                foreach (ManagementObject obj in searcher.Get())
                {
                    if (obj["Name"] != null)
                    {
                        gpu.Text = $"{obj["Name"]}";
                        break;
                    }
                }
            }
            catch { gpu.Text = "Não reconhecida"; }

            // Exibir nome do Disco
            try
            {
                var searcher = new ManagementObjectSearcher("SELECT Model FROM Win32_DiskDrive");
                foreach (ManagementObject obj in searcher.Get())
                {
                    if (obj["Model"] != null)
                    {
                        disco.Text = $"{obj["Model"]}";
                        break;
                    }
                }
            }
            catch { disco.Text = "Não reconhecido"; }

            // Garantir propriedades corretas do CircleProgressBar
            CpuPG_Circle.Minimum = 0;
            CpuPG_Circle.Maximum = 100;
            CpuPG_Circle.Value = 0;
            CpuPG_Circle.Text = "0%";
            CpuPG_Circle.ProgressColor = Color.Red;
            CpuPG_Circle.ProgressColor2 = Color.Red;
            CpuPG_Circle.FillColor = Color.Green;
            CpuPG_Circle.ShowText = true;
            CpuPG_Circle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            CpuPG_Circle.ForeColor = Color.White;
            CpuPG_Circle.UseTransparentBackground = false;

            // Inicializar o contador de CPU
            statuscpu = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            statuscpu.NextValue(); // Primeira leitura sempre retorna 0
            
            // Inicializar os contadores de Disco
            statusdisk = new PerformanceCounter("PhysicalDisk", "% Disk Time", "_Total");
            statusdiskRead = new PerformanceCounter("PhysicalDisk", "Disk Read Bytes/sec", "_Total");
            statusdiskWrite = new PerformanceCounter("PhysicalDisk", "Disk Write Bytes/sec", "_Total");
            statusdisk.NextValue();
            statusdiskRead.NextValue();
            statusdiskWrite.NextValue();

            // Configurar o timer para atualização em tempo real
            Timer attAll = new Timer();
            attAll.Interval = 1000; // Atualizar a cada 1 segundo
            attAll.Tick += update_all;
            attAll.Start();

            CentralizarLabels();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void guna2ImageButton1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2ImageButton1_Click_2(object sender, EventArgs e)
        {

        }

        private void guna2VSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void info_cpu(object sender = null, EventArgs e = null)
        {
            try
            {
                string cpu = "Não Reconhecido";

                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT Name FROM Win32_Processor");
                foreach (ManagementObject obj in searcher.Get())
                {
                    cpu = obj["Name"].ToString();
                    break;
                }

                this.cpu.Text = cpu;

            }
            catch (Exception)
            {
                cpu.Text = "Não Reconhecido";
            }
        }

        private void update_all(object sender, EventArgs e)
        {
            update_cpu();
            update_ram();
            update_disk();
            update_gpu();
        }

        private void update_cpu()
        {
            try
            {
                float usage = statuscpu.NextValue();
                int value = (int)Math.Min(usage, 100);
                CpuPG_Circle.Value = value;
                CpuPG_Circle.Text = $"{value}%";
                CpuPG_Circle.ProgressColor = Color.Red;
                CpuPG_Circle.ProgressColor2 = Color.Red;
                CpuPG_Circle.FillColor = Color.Green;
                CpuPG_Circle.Invalidate();
            }
            catch { CpuPG_Circle.Value = 0; CpuPG_Circle.Text = "0%"; }
        }

        private void update_ram()
        {
            try
            {
                var wmi = new ManagementObjectSearcher("SELECT TotalVisibleMemorySize, FreePhysicalMemory FROM Win32_OperatingSystem");
                foreach (ManagementObject obj in wmi.Get())
                {
                    ulong total = (ulong)obj["TotalVisibleMemorySize"];
                    ulong free = (ulong)obj["FreePhysicalMemory"];
                    ulong used = total - free;
                    int percent = (int)((used * 100) / total);
                    RamPG_Circle.Value = percent;
                    RamPG_Circle.Text = $"{percent}%";
                    RamPG_Circle.ProgressColor = Color.Red;
                    RamPG_Circle.ProgressColor2 = Color.Red;
                    RamPG_Circle.FillColor = Color.Green;
                    RamPG_Circle.ShowText = true;
                    RamPG_Circle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
                    RamPG_Circle.ForeColor = Color.White;
                    RamPG_Circle.Invalidate();
                }
            }
            catch { RamPG_Circle.Value = 0; RamPG_Circle.Text = "0%"; }
        }

        private void update_disk()
        {
            try
            {
                float read = statusdiskRead.NextValue();
                float write = statusdiskWrite.NextValue();
                float mbps = (read + write) / (1024 * 1024); // MB/s
                int percent = (int)Math.Min(statusdisk.NextValue(), 100);
                DiskPG_Circle.Value = percent;
                DiskPG_Circle.Text = $"{mbps:F1} MB/s";
                DiskPG_Circle.ProgressColor = Color.Red;
                DiskPG_Circle.ProgressColor2 = Color.Red;
                DiskPG_Circle.FillColor = Color.Green;
                DiskPG_Circle.ShowText = true;
                DiskPG_Circle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
                DiskPG_Circle.ForeColor = Color.White;
                DiskPG_Circle.Invalidate();
            }
            catch { DiskPG_Circle.Value = 0; DiskPG_Circle.Text = "0 MB/s"; }
        }

        private float GetGpuUsageDxgi()
        {
            try
            {
                var category = new PerformanceCounterCategory("GPU Engine");
                var instanceNames = category.GetInstanceNames();
                float totalUsage = 0;
                foreach (var name in instanceNames)
                {
                    if (name.ToLower().Contains("engtype_3d"))
                    {
                        using (var counter = new PerformanceCounter("GPU Engine", "Utilization Percentage", name))
                        {
                            totalUsage += counter.NextValue();
                        }
                    }
                }
                return totalUsage;
            }
            catch
            {
                return 0;
            }
        }

        private void update_gpu()
        {
            try
            {
                float gpuUsage = GetGpuUsageDxgi();
                int percent = (int)Math.Min(gpuUsage, 100);
                GpuPG_Circle.Value = percent;
                GpuPG_Circle.Text = $"{percent}%";
                GpuPG_Circle.ProgressColor = Color.Red;
                GpuPG_Circle.ProgressColor2 = Color.Red;
                GpuPG_Circle.FillColor = Color.Green;
                GpuPG_Circle.ShowText = true;
                GpuPG_Circle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
                GpuPG_Circle.ForeColor = Color.White;
                GpuPG_Circle.Invalidate();
            }
            catch { GpuPG_Circle.Value = 0; GpuPG_Circle.Text = "N/A"; }
        }

        private void PainelGeral_Painel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CentralizarLabels()
        {
            // CPU
            cpu.Left = CpuPG_Circle.Left + (CpuPG_Circle.Width - cpu.Width) / 2;
            cpu.Top = CpuPG_Circle.Top - cpu.Height - 5;

            // RAM
            ram.Left = RamPG_Circle.Left + (RamPG_Circle.Width - ram.Width) / 2;
            ram.Top = RamPG_Circle.Top - ram.Height - 5;

            // GPU
            gpu.Left = GpuPG_Circle.Left + (GpuPG_Circle.Width - gpu.Width) / 2;
            gpu.Top = GpuPG_Circle.Top - gpu.Height - 5;

            // DISCO
            disco.Left = DiskPG_Circle.Left + (DiskPG_Circle.Width - disco.Width) / 2;
            disco.Top = DiskPG_Circle.Top - disco.Height - 5;
        }

        private void gpu_Click(object sender, EventArgs e)
        {

        }

        private void SysCore_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
