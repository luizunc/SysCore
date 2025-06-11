using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace SysCore
{
    public class GraphPanel : Panel
    {
        private List<float> cpuValues;
        private List<float> ramValues;
        private List<float> gpuValues;
        private Timer updateTimer;
        private const int MAX_POINTS = 60;

        public GraphPanel()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.DoubleBuffered = true;
            cpuValues = new List<float>();
            ramValues = new List<float>();
            gpuValues = new List<float>();

            updateTimer = new Timer();
            updateTimer.Interval = 1000;
            updateTimer.Tick += UpdateTimer_Tick;
            updateTimer.Start();

            this.Paint += GraphPanel_Paint;
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
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

        private void GraphPanel_Paint(object sender, PaintEventArgs e)
        {
            if (cpuValues.Count == 0) return;

            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            var width = this.Width;
            var height = this.Height;
            var padding = 10;

            // Desenha o fundo
            using (var brush = new SolidBrush(Color.FromArgb(50, 0, 0, 0)))
            {
                g.FillRectangle(brush, 0, 0, width, height);
            }

            // Desenha as linhas de grade
            using (var pen = new Pen(Color.FromArgb(30, 255, 255, 255)))
            {
                for (int i = 0; i <= 4; i++)
                {
                    var y = padding + (height - 2 * padding) * i / 4;
                    g.DrawLine(pen, padding, y, width - padding, y);
                }
            }

            // Desenha os gráficos
            DrawGraph(g, cpuValues, Color.Red, width, height, padding);
            DrawGraph(g, ramValues, Color.Green, width, height, padding);
            DrawGraph(g, gpuValues, Color.Blue, width, height, padding);
        }

        private void DrawGraph(Graphics g, List<float> values, Color color, int width, int height, int padding)
        {
            if (values.Count < 2) return;

            var points = new PointF[values.Count];
            var maxValue = values.Max();
            var minValue = values.Min();
            var range = maxValue - minValue;
            if (range == 0) range = 1;

            for (int i = 0; i < values.Count; i++)
            {
                var x = padding + (width - 2 * padding) * i / (values.Count - 1);
                var y = padding + (height - 2 * padding) * (1 - (values[i] - minValue) / range);
                points[i] = new PointF(x, y);
            }

            using (var pen = new Pen(color, 2))
            {
                g.DrawLines(pen, points);
            }
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
    }
} 