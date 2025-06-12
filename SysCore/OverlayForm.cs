//  ######   ####     ##  ##   ######   #####
//  ##       ## ##    ##  ##       ##   ##  ##
//  ##       ##  ##   ##  ##      ##    ##  ##
//  ####     ##  ##   ##  ##     ##     #####
//  ##       ##  ##   ##  ##    ##      ##
//  ##       ## ##    ##  ##   ##       ##
//  ######   ####      ####    ######   ##

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using OpenHardwareMonitor.Hardware;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SysCore
{
    //
    // chatice isso, deu muito erro por causa de sensores.
    //
    public partial class OverlayForm : Form
    {
        private Timer updateTimer;
        private float cpuUsage, cpuTemp, cpuClock, cpuPower;
        private float ramUsage, ramUsed, ramTotal;
        private float gpuUsage, gpuTemp, gpuMemUsed, gpuMemTotal, gpuPower;
        private string vramStr = "--";
        private Font overlayFont;
        private bool alertColorsEnabled = false;
        private Computer computer;
        private Config configForm;
        private bool showHardwareName = false;
        private string cpuModel = "CPU";
        private string gpuModel = "GPU";
        private bool showCPU, showUSOCPU, showCLOCKCPU, showTEMPCPU, showCONSCPU;
        private bool showGPU, showUSOGPU, showVRAM, showTEMPGPU, showCONSGPU;
        private bool showRAM;
        private GraphPanel graphPanel;
        private bool showGraph = false;

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // OverlayForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 280);
            this.Name = "OverlayForm";
            this.Load += new System.EventHandler(this.OverlayForm_Load);
            this.ResumeLayout(false);

        }

        private void OverlayForm_Load(object sender, EventArgs e)
        {

        }

        private Color overlayBackgroundColor = Color.Transparent;
        private bool showOverlayBackground = false;

        [DllImport("user32.dll")]
        public static extern int SetLayeredWindowAttributes(IntPtr hwnd, int crKey, byte bAlpha, int dwFlags);
        const int LWA_COLORKEY = 0x1;
        const int LWA_ALPHA = 0x2;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x80000;
                return cp;
            }
        }

        public void SetOverlayAlpha(byte alpha)
        {
            SetLayeredWindowAttributes(this.Handle, 0, alpha, LWA_ALPHA);
        }

        public OverlayForm(Config config)
        {
            this.DoubleBuffered = true;
            InitializeComponents();
            InitializeHardwareMonitor();
            StartMonitoring();
            configForm = config;
            configForm.ColorChanged += (s, color) => {
                overlayBackgroundColor = color;
                this.Invalidate();
            };
            configForm.BackgroundColorChanged += (s, enabled) => {
                showOverlayBackground = enabled;
                this.Invalidate();
            };
            configForm.CoresAlertaChanged += (s, enabled) => { alertColorsEnabled = enabled; this.Invalidate(); };
            configForm.NomeHardwareChanged += (s, enabled) => { showHardwareName = enabled; this.Invalidate(); };
            configForm.MonitoramentoSelectionChanged += (s, sel) => {
                showCPU = sel.ShowCPU;
                showUSOCPU = sel.ShowUSOCPU;
                showCLOCKCPU = sel.ShowCLOCKCPU;
                showTEMPCPU = sel.ShowTEMPCPU;
                showCONSCPU = sel.ShowCONSCPU;
                showGPU = sel.ShowGPU;
                showUSOGPU = sel.ShowUSOGPU;
                showVRAM = sel.ShowVRAM;
                showTEMPGPU = sel.ShowTEMPGPU;
                showCONSGPU = sel.ShowCONSGPU;
                showRAM = sel.ShowRAM;
                this.Invalidate();
            };
            configForm.GraficosChanged += (s, enabled) => {
                showGraph = enabled;
                if (enabled)
                {
                    if (graphPanel == null || graphPanel.IsDisposed)
                        graphPanel = new GraphPanel();
                    //
                    // canto superior direito do monitor(por enquanto)
                    //
                    var screen = Screen.PrimaryScreen.Bounds;
                    graphPanel.Location = new Point(screen.Width - graphPanel.Width - 10, 10);
                    graphPanel.Show();
                }
                else
                {
                    if (graphPanel != null && !graphPanel.IsDisposed)
                        graphPanel.Hide();
                }
                this.Invalidate();
            };
            graphPanel = new GraphPanel();
            graphPanel.Size = new Size(320, 120);
            graphPanel.Location = new Point(this.Width - graphPanel.Width - 10, 10);
            graphPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            graphPanel.Visible = false;
            this.SizeChanged += (s, e) => {
                graphPanel.Location = new Point(this.Width - graphPanel.Width - 10, 10);
            };
        }

        private void InitializeComponents()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.ShowInTaskbar = false;
            this.BackColor = Color.Black;
            this.TransparencyKey = Color.Black;
            this.Size = new Size(380, 600);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            overlayFont = new Font("Segoe UI", 14, FontStyle.Bold);

            updateTimer = new Timer();
            updateTimer.Interval = 1000;
            updateTimer.Tick += UpdateTimer_Tick;
        }

        private void InitializeHardwareMonitor()
        {
            try
            {
                computer = new Computer()
                {
                    CPUEnabled = true,
                    RAMEnabled = true,
                    GPUEnabled = true
                };
                computer.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inicializar sensores: " + ex.Message);
            }
        }

        private void StartMonitoring()
        {
            updateTimer.Start();
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            UpdateHardwareInfo();
            if (showGraph && graphPanel != null && graphPanel.Visible)
                graphPanel.AddValues(cpuUsage, ramUsage, gpuUsage);
            this.Invalidate();
        }

        private void UpdateHardwareInfo()
        {
            try
            {
                cpuTemp = cpuClock = cpuUsage = cpuPower = 0;
                ramUsed = ramTotal = ramUsage = 0;
                gpuTemp = gpuUsage = gpuMemUsed = gpuMemTotal = gpuPower = 0;
                vramStr = "--";
                foreach (IHardware hardware in computer.Hardware)
                {
                    hardware.Update();
                    if (hardware.HardwareType == HardwareType.CPU)
                    {
                        if (string.IsNullOrEmpty(cpuModel) || cpuModel == "CPU")
                        {
                            cpuModel = hardware.Name;
                            cpuModel = RemoveManufacturer(cpuModel);
                        }
                        foreach (ISensor sensor in hardware.Sensors)
                        {
                            if (sensor.SensorType == SensorType.Temperature && sensor.Value.HasValue && cpuTemp == 0)
                                cpuTemp = sensor.Value.Value;
                            else if (sensor.SensorType == SensorType.Clock && sensor.Value.HasValue)
                            {
                                float currentClock = sensor.Value.Value / 1000f;
                                if (currentClock > cpuClock)
                                    cpuClock = currentClock;
                            }
                            else if (sensor.SensorType == SensorType.Load && sensor.Name.ToLower().Contains("total") && sensor.Value.HasValue)
                                cpuUsage = sensor.Value.Value;
                            else if (sensor.SensorType == SensorType.Power && sensor.Value.HasValue)
                                cpuPower = sensor.Value.Value;
                        }
                    }
                    else if (hardware.HardwareType == HardwareType.RAM)
                    {
                        foreach (ISensor sensor in hardware.Sensors)
                        {
                            if (sensor.SensorType == SensorType.Data && sensor.Name.ToLower().Contains("used") && sensor.Value.HasValue)
                                ramUsed = (float)Math.Floor(sensor.Value.Value * 1024f);
                            else if (sensor.SensorType == SensorType.Data && sensor.Name.ToLower().Contains("available") && sensor.Value.HasValue)
                                ramTotal = (float)Math.Floor((ramUsed / 1024f + sensor.Value.Value) * 1024f);
                            else if (sensor.SensorType == SensorType.Load && sensor.Value.HasValue)
                                ramUsage = sensor.Value.Value;
                        }
                    }
                    else if (hardware.HardwareType == HardwareType.GpuNvidia || hardware.HardwareType == HardwareType.GpuAti)
                    {
                        if (string.IsNullOrEmpty(gpuModel) || gpuModel == "GPU")
                        {
                            gpuModel = hardware.Name;
                            gpuModel = RemoveManufacturer(gpuModel);
                        }
                        foreach (ISensor sensor in hardware.Sensors)
                        {
                            if (sensor.SensorType == SensorType.Temperature && sensor.Value.HasValue && gpuTemp == 0)
                                gpuTemp = sensor.Value.Value;
                            else if (sensor.SensorType == SensorType.Load && sensor.Name.ToLower().Contains("core") && sensor.Value.HasValue)
                                gpuUsage = sensor.Value.Value;
                            else if (sensor.SensorType == SensorType.SmallData && sensor.Name.ToLower().Contains("used") && sensor.Value.HasValue)
                            {
                                float val = sensor.Value.Value;
                                if (val < 256)
                                    gpuMemUsed = (float)Math.Floor(val * 1024f);
                                else
                                    gpuMemUsed = (float)Math.Floor(val);
                            }
                            else if (sensor.SensorType == SensorType.SmallData && sensor.Name.ToLower().Contains("total") && sensor.Value.HasValue)
                            {
                                float val = sensor.Value.Value;
                                if (val < 256)
                                    gpuMemTotal = (float)Math.Floor(val * 1024f);
                                else
                                    gpuMemTotal = (float)Math.Floor(val);
                            }
                            else if (sensor.SensorType == SensorType.Power && sensor.Value.HasValue)
                                gpuPower = sensor.Value.Value;
                        }
                    }
                }
                vramStr = (gpuMemUsed > 0 && gpuMemUsed < 65536) ? $"{(int)gpuMemUsed}MB" : "N/A";
            }
            catch { }
        }

        private string RemoveManufacturer(string name)
        {
            if (string.IsNullOrEmpty(name)) return name;

            string[] fabricantes = { "Intel", "AMD", "NVIDIA", "GeForce", "Radeon", "Graphics", "Processor", "CPU", "(R)", "(TM)", "APU", "with", "Dual", "Quad", "Core", "Six", "Eight", "Twelve", "Sixteen", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety", "Hundred", "Family", "Series", "Mobile", "Desktop", "Laptop", "Processor", "Graphics" };
            foreach (var fab in fabricantes)
                name = System.Text.RegularExpressions.Regex.Replace(name, $@"\b{fab}\b", "", System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            name = System.Text.RegularExpressions.Regex.Replace(name, "\\s+", " ").Trim();

            if (name.StartsWith("RTX", StringComparison.OrdinalIgnoreCase) || name.StartsWith("GTX", StringComparison.OrdinalIgnoreCase) || name.StartsWith("RX", StringComparison.OrdinalIgnoreCase))
                return name.ToUpper();
            if (name.StartsWith("i", StringComparison.OrdinalIgnoreCase) && name.Length > 2 && char.IsDigit(name[1]))
                return name.ToUpper();
            return name;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;
            if (showOverlayBackground)
            {
                using (var brush = new SolidBrush(overlayBackgroundColor))
                {
                    g.FillRectangle(brush, this.ClientRectangle);
                }
            }
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            int y = 10;
            int leftPad = 10;
            int valuePad = 160;
            //
            // dinamicamente labels/values
            //
            var labels = new List<string>();
            var values = new List<string>();
            var groupColors = new List<Color>();
            if (showGPU) { labels.Add(showHardwareName ? gpuModel : "GPU"); values.Add($"{gpuUsage,4:0}%"); groupColors.Add(Color.Lime); }
            if (showUSOGPU) { labels.Add("USO GPU"); values.Add($"{gpuUsage,4:0}%"); groupColors.Add(Color.Lime); }
            if (showVRAM) { labels.Add("VRAM"); values.Add(vramStr); groupColors.Add(Color.Lime); }
            if (showTEMPGPU) { labels.Add("TEMP GPU"); values.Add($"{gpuTemp,4:0}°C"); groupColors.Add(Color.Lime); }
            if (showCONSGPU) { labels.Add("CONS. GPU"); values.Add($"{gpuPower,4:0}W"); groupColors.Add(Color.Lime); }
            if (showCPU) { labels.Add(showHardwareName ? cpuModel : "CPU"); values.Add($"{cpuUsage,4:0}%"); groupColors.Add(Color.Cyan); }
            if (showUSOCPU) { labels.Add("USO CPU"); values.Add($"{cpuUsage,4:0}%"); groupColors.Add(Color.Cyan); }
            if (showCLOCKCPU) { labels.Add("CLOCK CPU"); values.Add(cpuClock.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture) + " GHz"); groupColors.Add(Color.Cyan); }
            if (showTEMPCPU) { labels.Add("TEMP CPU"); values.Add($"{cpuTemp,4:0}°C"); groupColors.Add(Color.Cyan); }
            if (showCONSCPU) { labels.Add("CONS. CPU"); values.Add($"{cpuPower,4:0}W"); groupColors.Add(Color.Cyan); }
            if (showRAM) { labels.Add("RAM"); values.Add($"{(int)ramUsed}MB"); groupColors.Add(Color.Yellow); }
            //
            // 0 seleção, não desenha nada
            //
            for (int i = 0; i < labels.Count; i++)
            {
                using (var brush = new SolidBrush(groupColors[i]))
                    g.DrawString(labels[i], overlayFont, brush, leftPad, y);
                Color valColor = groupColors[i];
                if (alertColorsEnabled)
                {
                    float val = 0;
                    if (labels[i].Contains("USO GPU")) val = gpuUsage;
                    else if (labels[i].Contains("USO CPU")) val = cpuUsage;
                    else if (labels[i] == "VRAM") val = gpuMemUsed > 0 ? (gpuMemUsed / (gpuMemTotal > 0 ? gpuMemTotal : 1)) * 100 : 0;
                    else if (labels[i] == "TEMP GPU") val = gpuTemp;
                    else if (labels[i] == "CONS. GPU") val = gpuPower;
                    else if (labels[i] == "TEMP CPU") val = cpuTemp;
                    else if (labels[i] == "CONS. CPU") val = cpuPower;
                    else if (labels[i] == "RAM") val = ramUsed > 0 && ramTotal > 0 ? (ramUsed / ramTotal) * 100 : 0;
                    else if (labels[i] == (showHardwareName ? gpuModel : "GPU")) val = gpuUsage;
                    else if (labels[i] == (showHardwareName ? cpuModel : "CPU")) val = cpuUsage;
                    valColor = GetAlertColor(val);
                }
                SizeF valSize = g.MeasureString(values[i], overlayFont);
                using (var brush = new SolidBrush(valColor))
                    g.DrawString(values[i], overlayFont, brush, leftPad + valuePad, y);
                y += (int)valSize.Height + 2;
            }
        }

        private Color GetAlertColor(float value)
        {
            if (value <= 40) return Color.Green;
            if (value <= 50) return Color.Yellow;
            if (value <= 90) return Color.Orange;
            return Color.Red;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            try { updateTimer.Stop(); } catch { }
            try { computer.Close(); } catch { }
        }
    }
}

//  ######   ####     ##  ##   ######   #####
//  ##       ## ##    ##  ##       ##   ##  ##
//  ##       ##  ##   ##  ##      ##    ##  ##
//  ####     ##  ##   ##  ##     ##     #####
//  ##       ##  ##   ##  ##    ##      ##
//  ##       ## ##    ##  ##   ##       ##
//  ######   ####      ####    ######   ##