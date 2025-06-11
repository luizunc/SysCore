using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using OpenHardwareMonitor.Hardware;
using System.Diagnostics;

namespace SysCore
{
    public class OverlayForm : Form
    {
        private Timer updateTimer;
        private Label overlayLabel;
        private Font overlayFont;
        private Computer computer;

        public OverlayForm()
        {
            InitializeComponents();
            InitializeHardwareMonitor();
            StartMonitoring();
        }

        private void InitializeComponents()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.ShowInTaskbar = false;
            this.BackColor = Color.Black;
            this.TransparencyKey = Color.Black;
            this.Size = new Size(420, 160);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);

            overlayFont = new Font("Segoe UI", 16, FontStyle.Regular);

            overlayLabel = new Label
            {
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Font = overlayFont,
                AutoSize = false,
                Size = new Size(400, 140),
                Location = new Point(10, 10),
                TextAlign = ContentAlignment.TopLeft,
                Padding = new Padding(0),
            };

            this.Controls.Add(overlayLabel);

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
        }

        private void UpdateHardwareInfo()
        {
            try
            {
                float cpuTemp = 0, cpuClock = 0, cpuUsage = 0;
                int cpuCores = 0, cpuThreads = Environment.ProcessorCount;
                float ramUsed = 0, ramTotal = 0, ramUsage = 0;
                float gpuTemp = 0, gpuUsage = 0, gpuMemUsed = 0, gpuMemTotal = 0;
                string gpuName = "";

                foreach (IHardware hardware in computer.Hardware)
                {
                    hardware.Update();
                    if (hardware.HardwareType == HardwareType.CPU)
                    {
                        foreach (ISensor sensor in hardware.Sensors)
                        {
                            if (sensor.SensorType == SensorType.Temperature && sensor.Value.HasValue && cpuTemp == 0)
                                cpuTemp = sensor.Value.Value;
                            else if (sensor.SensorType == SensorType.Clock && sensor.Value.HasValue && cpuClock == 0)
                                cpuClock = sensor.Value.Value / 1000f; // MHz para GHz
                            else if (sensor.SensorType == SensorType.Load && sensor.Name.ToLower().Contains("total") && sensor.Value.HasValue)
                                cpuUsage = sensor.Value.Value;
                        }
                        cpuCores = hardware.Sensors.Count(s => s.Name.ToLower().Contains("core #"));
                    }
                    else if (hardware.HardwareType == HardwareType.RAM)
                    {
                        foreach (ISensor sensor in hardware.Sensors)
                        {
                            if (sensor.SensorType == SensorType.Data && sensor.Name.ToLower().Contains("used") && sensor.Value.HasValue)
                                ramUsed = sensor.Value.Value;
                            else if (sensor.SensorType == SensorType.Data && sensor.Name.ToLower().Contains("available") && sensor.Value.HasValue)
                                ramTotal = ramUsed + sensor.Value.Value;
                            else if (sensor.SensorType == SensorType.Load && sensor.Value.HasValue)
                                ramUsage = sensor.Value.Value;
                        }
                    }
                    else if (hardware.HardwareType == HardwareType.GpuNvidia || hardware.HardwareType == HardwareType.GpuAti)
                    {
                        gpuName = hardware.Name;
                        foreach (ISensor sensor in hardware.Sensors)
                        {
                            if (sensor.SensorType == SensorType.Temperature && sensor.Value.HasValue && gpuTemp == 0)
                                gpuTemp = sensor.Value.Value;
                            else if (sensor.SensorType == SensorType.Load && sensor.Name.ToLower().Contains("core") && sensor.Value.HasValue)
                                gpuUsage = sensor.Value.Value;
                            else if (sensor.SensorType == SensorType.SmallData && sensor.Name.ToLower().Contains("used") && sensor.Value.HasValue)
                                gpuMemUsed = sensor.Value.Value;
                            else if (sensor.SensorType == SensorType.SmallData && sensor.Name.ToLower().Contains("total") && sensor.Value.HasValue)
                                gpuMemTotal = sensor.Value.Value;
                        }
                    }
                }

                // Ajuste de RAM para exibir simplificado
                string ramStr = $"{ramUsed,4:0.0}G/{ramTotal,4:0.0}GB";

                // Ajuste de VRAM para exibir simplificado
                if (gpuMemUsed > 100) // Provavelmente está em MB
                    gpuMemUsed = gpuMemUsed / 1024f;
                string vramStr = gpuMemUsed > 0 ? $"{gpuMemUsed:0.0}GB" : "--";

                // Monta texto do overlay
                string overlayText = "";
                overlayText += $"CPU:  {cpuUsage,4:0}%  {cpuTemp,4:0}°C  {cpuClock,4:0.00} GHz\n";
                overlayText += $"RAM:  {ramStr}  {ramUsage,4:0}%\n";
                overlayText += $"GPU:  {gpuUsage,4:0}%  {gpuTemp,4:0}°C  {vramStr} VRAM\n";

                overlayLabel.Text = overlayText;
            }
            catch (Exception ex)
            {
                overlayLabel.Text = "Erro ao acessar sensores: " + ex.Message;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            try { updateTimer.Stop(); } catch { }
            try { computer.Close(); } catch { }
        }
    }
} 