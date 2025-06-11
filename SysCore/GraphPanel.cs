using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace SysCore
{
    public class GraphPanel : Form
    {
        private List<float> cpuValues;
        private List<float> ramValues;
        private List<float> gpuValues;
        private Timer updateTimer;
        private const int MAX_POINTS = 60;
        private Color cpuColor = Color.Cyan;
        private Color gpuColor = Color.Lime;
        private Color ramColor = Color.Yellow;

        public GraphPanel()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.ShowInTaskbar = false;
            this.BackColor = Color.Black;
            this.TransparencyKey = Color.Black;
            this.Size = new Size(320, 120);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width - 10, 10);
            this.DoubleBuffered = true;
            cpuValues = new List<float>();
            ramValues = new List<float>();
            gpuValues = new List<float>();
            updateTimer = new Timer();
            updateTimer.Interval = 1000;
            updateTimer.Tick += (s, e) => this.Invalidate();
            updateTimer.Start();
            this.Paint += GraphPanel_Paint;
        }

        private void GraphPanel_Paint(object sender, PaintEventArgs e)
        {
            if (cpuValues.Count == 0) return;

            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            var width = this.Width;
            var height = this.Height;
            var padding = 10;
            int points = cpuValues.Count;
            float xStep = (float)(width - 2 * padding) / (MAX_POINTS - 1);

            // Espaçamento vertical para as 3 linhas
            float bandHeight = (height - 2 * padding) / 3f;
            float cpuOffset = 0;
            float gpuOffset = bandHeight;
            float ramOffset = 2 * bandHeight;

            void DrawLine(List<float> values, Color color, float yOffset)
            {
                if (values.Count < 2) return;
                using (var pen = new Pen(color, 2.5f))
                {
                    for (int i = 1; i < values.Count; i++)
                    {
                        float x1 = padding + (i - 1) * xStep;
                        float x2 = padding + i * xStep;
                        float y1 = height - padding - yOffset - (values[i - 1] / 100f) * bandHeight;
                        float y2 = height - padding - yOffset - (values[i] / 100f) * bandHeight;
                        g.DrawLine(pen, x1, y1, x2, y2);
                    }
                }
            }

            DrawLine(cpuValues, cpuColor, cpuOffset);
            DrawLine(gpuValues, gpuColor, gpuOffset);
            DrawLine(ramValues, ramColor, ramOffset);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                updateTimer.Stop();
                updateTimer.Dispose();
            }
            base.Dispose(disposing);
        }

        public void AddValues(float cpu, float ram, float gpu)
        {
            cpuValues.Add(cpu);
            ramValues.Add(ram);
            gpuValues.Add(gpu);

            if (cpuValues.Count > MAX_POINTS)
            {
                cpuValues.RemoveAt(0);
                ramValues.RemoveAt(0);
                gpuValues.RemoveAt(0);
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // GraphPanel
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "GraphPanel";
            this.ResumeLayout(false);

        }
    }
} 