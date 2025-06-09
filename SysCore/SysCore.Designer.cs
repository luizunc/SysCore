namespace SysCore
{
    partial class SysCore_Form
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SysCore_Form));
            this.SysCore_Bordless = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.Close_button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Minimize_button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SysCoreLogo_Form = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SysCore_SeparatorV = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.Conf_Button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.PainelGeral_Painel = new Guna.UI2.WinForms.Guna2Panel();
            this.CpuPG_Circle = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.cpu = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.RamPG_Circle = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.ram = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.GpuPG_Circle = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.gpu = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.DiskPG_Circle = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.disco = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PainelGeral_Painel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SysCore_Bordless
            // 
            this.SysCore_Bordless.ContainerControl = this;
            this.SysCore_Bordless.DockIndicatorTransparencyValue = 0.6D;
            this.SysCore_Bordless.ResizeForm = false;
            this.SysCore_Bordless.TransparentWhileDrag = true;
            // 
            // Close_button
            // 
            this.Close_button.CheckedState.ImageSize = new System.Drawing.Size(10, 10);
            this.Close_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_button.HoverState.ImageSize = new System.Drawing.Size(10, 10);
            this.Close_button.Image = ((System.Drawing.Image)(resources.GetObject("Close_button.Image")));
            this.Close_button.ImageOffset = new System.Drawing.Point(0, 0);
            this.Close_button.ImageRotate = 0F;
            this.Close_button.ImageSize = new System.Drawing.Size(10, 10);
            this.Close_button.Location = new System.Drawing.Point(770, 12);
            this.Close_button.Name = "Close_button";
            this.Close_button.PressedState.ImageSize = new System.Drawing.Size(10, 10);
            this.Close_button.Size = new System.Drawing.Size(18, 19);
            this.Close_button.TabIndex = 0;
            this.Close_button.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // Minimize_button
            // 
            this.Minimize_button.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Minimize_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize_button.HoverState.ImageSize = new System.Drawing.Size(10, 10);
            this.Minimize_button.Image = ((System.Drawing.Image)(resources.GetObject("Minimize_button.Image")));
            this.Minimize_button.ImageOffset = new System.Drawing.Point(0, 0);
            this.Minimize_button.ImageRotate = 0F;
            this.Minimize_button.ImageSize = new System.Drawing.Size(10, 10);
            this.Minimize_button.Location = new System.Drawing.Point(746, 12);
            this.Minimize_button.Name = "Minimize_button";
            this.Minimize_button.PressedState.ImageSize = new System.Drawing.Size(10, 10);
            this.Minimize_button.Size = new System.Drawing.Size(18, 19);
            this.Minimize_button.TabIndex = 1;
            this.Minimize_button.Click += new System.EventHandler(this.guna2ImageButton1_Click_1);
            // 
            // SysCoreLogo_Form
            // 
            this.SysCoreLogo_Form.BackColor = System.Drawing.Color.Transparent;
            this.SysCoreLogo_Form.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.SysCoreLogo_Form.HoverState.ImageSize = new System.Drawing.Size(75, 75);
            this.SysCoreLogo_Form.Image = ((System.Drawing.Image)(resources.GetObject("SysCoreLogo_Form.Image")));
            this.SysCoreLogo_Form.ImageOffset = new System.Drawing.Point(0, 0);
            this.SysCoreLogo_Form.ImageRotate = 0F;
            this.SysCoreLogo_Form.ImageSize = new System.Drawing.Size(75, 75);
            this.SysCoreLogo_Form.Location = new System.Drawing.Point(12, 12);
            this.SysCoreLogo_Form.Name = "SysCoreLogo_Form";
            this.SysCoreLogo_Form.PressedState.ImageSize = new System.Drawing.Size(75, 75);
            this.SysCoreLogo_Form.Size = new System.Drawing.Size(75, 75);
            this.SysCoreLogo_Form.TabIndex = 2;
            this.SysCoreLogo_Form.Click += new System.EventHandler(this.guna2ImageButton1_Click_2);
            // 
            // SysCore_SeparatorV
            // 
            this.SysCore_SeparatorV.FillColor = System.Drawing.Color.White;
            this.SysCore_SeparatorV.FillThickness = 2;
            this.SysCore_SeparatorV.Location = new System.Drawing.Point(93, 12);
            this.SysCore_SeparatorV.Name = "SysCore_SeparatorV";
            this.SysCore_SeparatorV.Size = new System.Drawing.Size(10, 426);
            this.SysCore_SeparatorV.TabIndex = 3;
            this.SysCore_SeparatorV.Click += new System.EventHandler(this.guna2VSeparator1_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.Gray;
            this.guna2Separator1.Location = new System.Drawing.Point(17, 77);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(70, 10);
            this.guna2Separator1.TabIndex = 4;
            // 
            // Conf_Button
            // 
            this.Conf_Button.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Conf_Button.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.Conf_Button.Image = ((System.Drawing.Image)(resources.GetObject("Conf_Button.Image")));
            this.Conf_Button.ImageOffset = new System.Drawing.Point(0, 0);
            this.Conf_Button.ImageRotate = 0F;
            this.Conf_Button.ImageSize = new System.Drawing.Size(32, 32);
            this.Conf_Button.Location = new System.Drawing.Point(12, 395);
            this.Conf_Button.Name = "Conf_Button";
            this.Conf_Button.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.Conf_Button.Size = new System.Drawing.Size(46, 43);
            this.Conf_Button.TabIndex = 5;
            // 
            // PainelGeral_Painel
            // 
            this.PainelGeral_Painel.Controls.Add(this.CpuPG_Circle);
            this.PainelGeral_Painel.Controls.Add(this.cpu);
            this.PainelGeral_Painel.Controls.Add(this.RamPG_Circle);
            this.PainelGeral_Painel.Controls.Add(this.ram);
            this.PainelGeral_Painel.Controls.Add(this.GpuPG_Circle);
            this.PainelGeral_Painel.Controls.Add(this.gpu);
            this.PainelGeral_Painel.Controls.Add(this.DiskPG_Circle);
            this.PainelGeral_Painel.Controls.Add(this.disco);
            this.PainelGeral_Painel.Location = new System.Drawing.Point(109, 38);
            this.PainelGeral_Painel.Name = "PainelGeral_Painel";
            this.PainelGeral_Painel.Size = new System.Drawing.Size(679, 400);
            this.PainelGeral_Painel.TabIndex = 6;
            this.PainelGeral_Painel.Paint += new System.Windows.Forms.PaintEventHandler(this.PainelGeral_Painel_Paint);
            // 
            // CpuPG_Circle
            // 
            this.CpuPG_Circle.FillColor = System.Drawing.Color.Green;
            this.CpuPG_Circle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.CpuPG_Circle.ForeColor = System.Drawing.Color.White;
            this.CpuPG_Circle.Location = new System.Drawing.Point(93, 29);
            this.CpuPG_Circle.Minimum = 0;
            this.CpuPG_Circle.Name = "CpuPG_Circle";
            this.CpuPG_Circle.ProgressColor = System.Drawing.Color.Red;
            this.CpuPG_Circle.ProgressColor2 = System.Drawing.Color.Red;
            this.CpuPG_Circle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.CpuPG_Circle.Size = new System.Drawing.Size(130, 130);
            this.CpuPG_Circle.TabIndex = 1;
            // 
            // cpu
            // 
            this.cpu.BackColor = System.Drawing.Color.Transparent;
            this.cpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpu.ForeColor = System.Drawing.Color.White;
            this.cpu.Location = new System.Drawing.Point(94, 3);
            this.cpu.Name = "cpu";
            this.cpu.Size = new System.Drawing.Size(38, 20);
            this.cpu.TabIndex = 0;
            this.cpu.Text = "CPU";
            this.cpu.Click += new System.EventHandler(this.info_cpu);
            // 
            // RamPG_Circle
            // 
            this.RamPG_Circle.FillColor = System.Drawing.Color.Green;
            this.RamPG_Circle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.RamPG_Circle.ForeColor = System.Drawing.Color.White;
            this.RamPG_Circle.Location = new System.Drawing.Point(93, 267);
            this.RamPG_Circle.Minimum = 0;
            this.RamPG_Circle.Name = "RamPG_Circle";
            this.RamPG_Circle.ProgressColor = System.Drawing.Color.Red;
            this.RamPG_Circle.ProgressColor2 = System.Drawing.Color.Red;
            this.RamPG_Circle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.RamPG_Circle.Size = new System.Drawing.Size(130, 130);
            this.RamPG_Circle.TabIndex = 2;
            // 
            // ram
            // 
            this.ram.BackColor = System.Drawing.Color.Transparent;
            this.ram.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ram.ForeColor = System.Drawing.Color.White;
            this.ram.Location = new System.Drawing.Point(93, 241);
            this.ram.Name = "ram";
            this.ram.Size = new System.Drawing.Size(39, 20);
            this.ram.TabIndex = 3;
            this.ram.Text = "RAM";
            // 
            // GpuPG_Circle
            // 
            this.GpuPG_Circle.FillColor = System.Drawing.Color.Green;
            this.GpuPG_Circle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.GpuPG_Circle.ForeColor = System.Drawing.Color.White;
            this.GpuPG_Circle.Location = new System.Drawing.Point(434, 29);
            this.GpuPG_Circle.Minimum = 0;
            this.GpuPG_Circle.Name = "GpuPG_Circle";
            this.GpuPG_Circle.ProgressColor = System.Drawing.Color.Red;
            this.GpuPG_Circle.ProgressColor2 = System.Drawing.Color.Red;
            this.GpuPG_Circle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.GpuPG_Circle.Size = new System.Drawing.Size(130, 130);
            this.GpuPG_Circle.TabIndex = 4;
            // 
            // gpu
            // 
            this.gpu.BackColor = System.Drawing.Color.Transparent;
            this.gpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpu.ForeColor = System.Drawing.Color.White;
            this.gpu.Location = new System.Drawing.Point(434, 3);
            this.gpu.Name = "gpu";
            this.gpu.Size = new System.Drawing.Size(39, 20);
            this.gpu.TabIndex = 5;
            this.gpu.Text = "GPU";
            this.gpu.Click += new System.EventHandler(this.gpu_Click);
            // 
            // DiskPG_Circle
            // 
            this.DiskPG_Circle.FillColor = System.Drawing.Color.Green;
            this.DiskPG_Circle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.DiskPG_Circle.ForeColor = System.Drawing.Color.White;
            this.DiskPG_Circle.Location = new System.Drawing.Point(434, 267);
            this.DiskPG_Circle.Minimum = 0;
            this.DiskPG_Circle.Name = "DiskPG_Circle";
            this.DiskPG_Circle.ProgressColor = System.Drawing.Color.Red;
            this.DiskPG_Circle.ProgressColor2 = System.Drawing.Color.Red;
            this.DiskPG_Circle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.DiskPG_Circle.Size = new System.Drawing.Size(130, 130);
            this.DiskPG_Circle.TabIndex = 6;
            // 
            // disco
            // 
            this.disco.BackColor = System.Drawing.Color.Transparent;
            this.disco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disco.ForeColor = System.Drawing.Color.White;
            this.disco.Location = new System.Drawing.Point(434, 241);
            this.disco.Name = "disco";
            this.disco.Size = new System.Drawing.Size(55, 20);
            this.disco.TabIndex = 7;
            this.disco.Text = "DISCO";
            // 
            // SysCore_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PainelGeral_Painel);
            this.Controls.Add(this.Conf_Button);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.SysCore_SeparatorV);
            this.Controls.Add(this.SysCoreLogo_Form);
            this.Controls.Add(this.Minimize_button);
            this.Controls.Add(this.Close_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SysCore_Form";
            this.Text = "SysCore";
            this.PainelGeral_Painel.ResumeLayout(false);
            this.PainelGeral_Painel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm SysCore_Bordless;
        private Guna.UI2.WinForms.Guna2ImageButton Close_button;
        private Guna.UI2.WinForms.Guna2ImageButton Minimize_button;
        private Guna.UI2.WinForms.Guna2ImageButton SysCoreLogo_Form;
        private Guna.UI2.WinForms.Guna2VSeparator SysCore_SeparatorV;
        private Guna.UI2.WinForms.Guna2ImageButton Conf_Button;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Panel PainelGeral_Painel;
        private Guna.UI2.WinForms.Guna2CircleProgressBar CpuPG_Circle;
        private Guna.UI2.WinForms.Guna2CircleProgressBar RamPG_Circle;
        private Guna.UI2.WinForms.Guna2CircleProgressBar GpuPG_Circle;
        private Guna.UI2.WinForms.Guna2CircleProgressBar DiskPG_Circle;
        private Guna.UI2.WinForms.Guna2HtmlLabel cpu;
        private Guna.UI2.WinForms.Guna2HtmlLabel ram;
        private Guna.UI2.WinForms.Guna2HtmlLabel gpu;
        private Guna.UI2.WinForms.Guna2HtmlLabel disco;
    }
}

