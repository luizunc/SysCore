namespace SysCore
{
    partial class Config
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            this.Confi_Form = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.Config_SeparatorV = new Guna.UI2.WinForms.Guna2VSeparator();
            this.GeralButton = new Guna.UI2.WinForms.Guna2Button();
            this.MonitoramentoButton = new Guna.UI2.WinForms.Guna2Button();
            this.LogsButton = new Guna.UI2.WinForms.Guna2Button();
            this.PropriedadesButton = new Guna.UI2.WinForms.Guna2Button();
            this.CloseConfig_button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.PanelGeral_Config = new Guna.UI2.WinForms.Guna2Panel();
            this.BuscarErrosButton = new Guna.UI2.WinForms.Guna2Button();
            this.BuscarErrosLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.UpdateCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.UpdateLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PanelMonitoramento_Config = new Guna.UI2.WinForms.Guna2Panel();
            this.NomeHardware_Button = new Guna.UI2.WinForms.Guna2CheckBox();
            this.RAM_CHECK = new Guna.UI2.WinForms.Guna2CheckBox();
            this.CONSCPU_CHECK = new Guna.UI2.WinForms.Guna2CheckBox();
            this.TEMPCPU_CHECK = new Guna.UI2.WinForms.Guna2CheckBox();
            this.CLOCKCPU_CHECK = new Guna.UI2.WinForms.Guna2CheckBox();
            this.USOCPU_CHECK = new Guna.UI2.WinForms.Guna2CheckBox();
            this.CPU_CHECK = new Guna.UI2.WinForms.Guna2CheckBox();
            this.CONSGPU_CHECK = new Guna.UI2.WinForms.Guna2CheckBox();
            this.TEMPGPU_CHECK = new Guna.UI2.WinForms.Guna2CheckBox();
            this.VRAM_CHECK = new Guna.UI2.WinForms.Guna2CheckBox();
            this.USOGPU_CHECK = new Guna.UI2.WinForms.Guna2CheckBox();
            this.GPU_CHECK = new Guna.UI2.WinForms.Guna2CheckBox();
            this.SCor_Label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ColorWheel_Button = new Guna.UI2.WinForms.Guna2Button();
            this.CoresAlerta_Check = new Guna.UI2.WinForms.Guna2CheckBox();
            this.GRAFICOS_CHECK = new Guna.UI2.WinForms.Guna2CheckBox();
            this.PanelGeral_Config.SuspendLayout();
            this.PanelMonitoramento_Config.SuspendLayout();
            this.SuspendLayout();
            // 
            // Confi_Form
            // 
            this.Confi_Form.ContainerControl = this;
            this.Confi_Form.DockIndicatorTransparencyValue = 0.6D;
            this.Confi_Form.ResizeForm = false;
            this.Confi_Form.TransparentWhileDrag = true;
            // 
            // Config_SeparatorV
            // 
            this.Config_SeparatorV.FillColor = System.Drawing.Color.White;
            this.Config_SeparatorV.FillThickness = 2;
            this.Config_SeparatorV.Location = new System.Drawing.Point(152, -11);
            this.Config_SeparatorV.Name = "Config_SeparatorV";
            this.Config_SeparatorV.Size = new System.Drawing.Size(10, 426);
            this.Config_SeparatorV.TabIndex = 4;
            // 
            // GeralButton
            // 
            this.GeralButton.BackColor = System.Drawing.Color.Transparent;
            this.GeralButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.GeralButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.GeralButton.CheckedState.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GeralButton.CheckedState.CustomBorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GeralButton.CheckedState.FillColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GeralButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GeralButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GeralButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GeralButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GeralButton.FillColor = System.Drawing.Color.Black;
            this.GeralButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GeralButton.ForeColor = System.Drawing.Color.White;
            this.GeralButton.Location = new System.Drawing.Point(12, 50);
            this.GeralButton.Name = "GeralButton";
            this.GeralButton.Size = new System.Drawing.Size(134, 32);
            this.GeralButton.TabIndex = 7;
            this.GeralButton.Text = "Geral";
            this.GeralButton.Click += new System.EventHandler(this.Geral_Click);
            // 
            // MonitoramentoButton
            // 
            this.MonitoramentoButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.MonitoramentoButton.CheckedState.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MonitoramentoButton.CheckedState.CustomBorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MonitoramentoButton.CheckedState.FillColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MonitoramentoButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MonitoramentoButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MonitoramentoButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MonitoramentoButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MonitoramentoButton.FillColor = System.Drawing.Color.Black;
            this.MonitoramentoButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MonitoramentoButton.ForeColor = System.Drawing.Color.White;
            this.MonitoramentoButton.Location = new System.Drawing.Point(12, 88);
            this.MonitoramentoButton.Name = "MonitoramentoButton";
            this.MonitoramentoButton.Size = new System.Drawing.Size(134, 32);
            this.MonitoramentoButton.TabIndex = 8;
            this.MonitoramentoButton.Text = "Monitoramento";
            this.MonitoramentoButton.CheckedChanged += new System.EventHandler(this.MonitoramentoButton_CheckedChanged);
            this.MonitoramentoButton.Click += new System.EventHandler(this.MonitoramentoButton_Click);
            // 
            // LogsButton
            // 
            this.LogsButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.LogsButton.CheckedState.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LogsButton.CheckedState.CustomBorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LogsButton.CheckedState.FillColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LogsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LogsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LogsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LogsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LogsButton.FillColor = System.Drawing.Color.Black;
            this.LogsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LogsButton.ForeColor = System.Drawing.Color.White;
            this.LogsButton.Location = new System.Drawing.Point(12, 126);
            this.LogsButton.Name = "LogsButton";
            this.LogsButton.Size = new System.Drawing.Size(134, 32);
            this.LogsButton.TabIndex = 9;
            this.LogsButton.Text = "Logs";
            // 
            // PropriedadesButton
            // 
            this.PropriedadesButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.PropriedadesButton.CheckedState.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PropriedadesButton.CheckedState.CustomBorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PropriedadesButton.CheckedState.FillColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PropriedadesButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PropriedadesButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PropriedadesButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PropriedadesButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PropriedadesButton.FillColor = System.Drawing.Color.Black;
            this.PropriedadesButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PropriedadesButton.ForeColor = System.Drawing.Color.White;
            this.PropriedadesButton.Location = new System.Drawing.Point(12, 164);
            this.PropriedadesButton.Name = "PropriedadesButton";
            this.PropriedadesButton.Size = new System.Drawing.Size(134, 32);
            this.PropriedadesButton.TabIndex = 10;
            this.PropriedadesButton.Text = "Propriedades";
            // 
            // CloseConfig_button
            // 
            this.CloseConfig_button.CheckedState.ImageSize = new System.Drawing.Size(10, 10);
            this.CloseConfig_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseConfig_button.HoverState.ImageSize = new System.Drawing.Size(10, 10);
            this.CloseConfig_button.Image = ((System.Drawing.Image)(resources.GetObject("CloseConfig_button.Image")));
            this.CloseConfig_button.ImageOffset = new System.Drawing.Point(0, 0);
            this.CloseConfig_button.ImageRotate = 0F;
            this.CloseConfig_button.ImageSize = new System.Drawing.Size(10, 10);
            this.CloseConfig_button.Location = new System.Drawing.Point(470, 12);
            this.CloseConfig_button.Name = "CloseConfig_button";
            this.CloseConfig_button.PressedState.ImageSize = new System.Drawing.Size(10, 10);
            this.CloseConfig_button.Size = new System.Drawing.Size(18, 19);
            this.CloseConfig_button.TabIndex = 11;
            this.CloseConfig_button.Click += new System.EventHandler(this.CloseConfig_button_Click);
            // 
            // PanelGeral_Config
            // 
            this.PanelGeral_Config.Controls.Add(this.BuscarErrosButton);
            this.PanelGeral_Config.Controls.Add(this.BuscarErrosLabel);
            this.PanelGeral_Config.Controls.Add(this.UpdateCombo);
            this.PanelGeral_Config.Controls.Add(this.UpdateLabel);
            this.PanelGeral_Config.Location = new System.Drawing.Point(12, 323);
            this.PanelGeral_Config.Name = "PanelGeral_Config";
            this.PanelGeral_Config.Size = new System.Drawing.Size(320, 288);
            this.PanelGeral_Config.TabIndex = 12;
            // 
            // BuscarErrosButton
            // 
            this.BuscarErrosButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BuscarErrosButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BuscarErrosButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BuscarErrosButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BuscarErrosButton.FillColor = System.Drawing.Color.White;
            this.BuscarErrosButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BuscarErrosButton.ForeColor = System.Drawing.Color.Black;
            this.BuscarErrosButton.Location = new System.Drawing.Point(177, 24);
            this.BuscarErrosButton.Name = "BuscarErrosButton";
            this.BuscarErrosButton.Size = new System.Drawing.Size(140, 36);
            this.BuscarErrosButton.TabIndex = 3;
            this.BuscarErrosButton.Text = "Verificar Erros";
            // 
            // BuscarErrosLabel
            // 
            this.BuscarErrosLabel.BackColor = System.Drawing.Color.Transparent;
            this.BuscarErrosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarErrosLabel.ForeColor = System.Drawing.Color.White;
            this.BuscarErrosLabel.Location = new System.Drawing.Point(177, 0);
            this.BuscarErrosLabel.Name = "BuscarErrosLabel";
            this.BuscarErrosLabel.Size = new System.Drawing.Size(80, 18);
            this.BuscarErrosLabel.TabIndex = 2;
            this.BuscarErrosLabel.Text = "Buscar Erros";
            // 
            // UpdateCombo
            // 
            this.UpdateCombo.BackColor = System.Drawing.Color.Transparent;
            this.UpdateCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.UpdateCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UpdateCombo.FocusedColor = System.Drawing.Color.Black;
            this.UpdateCombo.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.UpdateCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.UpdateCombo.ForeColor = System.Drawing.Color.Black;
            this.UpdateCombo.ItemHeight = 30;
            this.UpdateCombo.Items.AddRange(new object[] {
            "Diariamente",
            "Semanalmente",
            "Mensalmente"});
            this.UpdateCombo.Location = new System.Drawing.Point(15, 24);
            this.UpdateCombo.Name = "UpdateCombo";
            this.UpdateCombo.Size = new System.Drawing.Size(140, 36);
            this.UpdateCombo.StartIndex = 0;
            this.UpdateCombo.TabIndex = 1;
            // 
            // UpdateLabel
            // 
            this.UpdateLabel.BackColor = System.Drawing.Color.Transparent;
            this.UpdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateLabel.ForeColor = System.Drawing.Color.White;
            this.UpdateLabel.Location = new System.Drawing.Point(15, 0);
            this.UpdateLabel.Name = "UpdateLabel";
            this.UpdateLabel.Size = new System.Drawing.Size(128, 18);
            this.UpdateLabel.TabIndex = 0;
            this.UpdateLabel.Text = "Buscar Atualizações:";
            // 
            // PanelMonitoramento_Config
            // 
            this.PanelMonitoramento_Config.Controls.Add(this.GRAFICOS_CHECK);
            this.PanelMonitoramento_Config.Controls.Add(this.NomeHardware_Button);
            this.PanelMonitoramento_Config.Controls.Add(this.RAM_CHECK);
            this.PanelMonitoramento_Config.Controls.Add(this.CONSCPU_CHECK);
            this.PanelMonitoramento_Config.Controls.Add(this.TEMPCPU_CHECK);
            this.PanelMonitoramento_Config.Controls.Add(this.CLOCKCPU_CHECK);
            this.PanelMonitoramento_Config.Controls.Add(this.USOCPU_CHECK);
            this.PanelMonitoramento_Config.Controls.Add(this.CPU_CHECK);
            this.PanelMonitoramento_Config.Controls.Add(this.CONSGPU_CHECK);
            this.PanelMonitoramento_Config.Controls.Add(this.TEMPGPU_CHECK);
            this.PanelMonitoramento_Config.Controls.Add(this.VRAM_CHECK);
            this.PanelMonitoramento_Config.Controls.Add(this.USOGPU_CHECK);
            this.PanelMonitoramento_Config.Controls.Add(this.GPU_CHECK);
            this.PanelMonitoramento_Config.Controls.Add(this.SCor_Label);
            this.PanelMonitoramento_Config.Controls.Add(this.ColorWheel_Button);
            this.PanelMonitoramento_Config.Controls.Add(this.CoresAlerta_Check);
            this.PanelMonitoramento_Config.Location = new System.Drawing.Point(168, 50);
            this.PanelMonitoramento_Config.Name = "PanelMonitoramento_Config";
            this.PanelMonitoramento_Config.Size = new System.Drawing.Size(320, 288);
            this.PanelMonitoramento_Config.TabIndex = 13;
            // 
            // NomeHardware_Button
            // 
            this.NomeHardware_Button.AutoSize = true;
            this.NomeHardware_Button.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NomeHardware_Button.CheckedState.BorderRadius = 0;
            this.NomeHardware_Button.CheckedState.BorderThickness = 0;
            this.NomeHardware_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NomeHardware_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeHardware_Button.ForeColor = System.Drawing.Color.White;
            this.NomeHardware_Button.Location = new System.Drawing.Point(21, 25);
            this.NomeHardware_Button.Name = "NomeHardware_Button";
            this.NomeHardware_Button.Size = new System.Drawing.Size(125, 20);
            this.NomeHardware_Button.TabIndex = 16;
            this.NomeHardware_Button.Text = "Nome Hardware";
            this.NomeHardware_Button.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.NomeHardware_Button.UncheckedState.BorderRadius = 0;
            this.NomeHardware_Button.UncheckedState.BorderThickness = 0;
            this.NomeHardware_Button.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.NomeHardware_Button.CheckedChanged += new System.EventHandler(this.NomeHardware_Button_CheckedChanged);
            // 
            // RAM_CHECK
            // 
            this.RAM_CHECK.AutoSize = true;
            this.RAM_CHECK.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RAM_CHECK.CheckedState.BorderRadius = 0;
            this.RAM_CHECK.CheckedState.BorderThickness = 0;
            this.RAM_CHECK.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RAM_CHECK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RAM_CHECK.ForeColor = System.Drawing.Color.White;
            this.RAM_CHECK.Location = new System.Drawing.Point(192, 180);
            this.RAM_CHECK.Name = "RAM_CHECK";
            this.RAM_CHECK.Size = new System.Drawing.Size(56, 20);
            this.RAM_CHECK.TabIndex = 15;
            this.RAM_CHECK.Text = "RAM";
            this.RAM_CHECK.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RAM_CHECK.UncheckedState.BorderRadius = 0;
            this.RAM_CHECK.UncheckedState.BorderThickness = 0;
            this.RAM_CHECK.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RAM_CHECK.CheckedChanged += new System.EventHandler(this.RAM_CHECK_CheckedChanged);
            // 
            // CONSCPU_CHECK
            // 
            this.CONSCPU_CHECK.AutoSize = true;
            this.CONSCPU_CHECK.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CONSCPU_CHECK.CheckedState.BorderRadius = 0;
            this.CONSCPU_CHECK.CheckedState.BorderThickness = 0;
            this.CONSCPU_CHECK.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CONSCPU_CHECK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONSCPU_CHECK.ForeColor = System.Drawing.Color.White;
            this.CONSCPU_CHECK.Location = new System.Drawing.Point(192, 154);
            this.CONSCPU_CHECK.Name = "CONSCPU_CHECK";
            this.CONSCPU_CHECK.Size = new System.Drawing.Size(98, 20);
            this.CONSCPU_CHECK.TabIndex = 14;
            this.CONSCPU_CHECK.Text = "CONS. CPU";
            this.CONSCPU_CHECK.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CONSCPU_CHECK.UncheckedState.BorderRadius = 0;
            this.CONSCPU_CHECK.UncheckedState.BorderThickness = 0;
            this.CONSCPU_CHECK.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CONSCPU_CHECK.CheckedChanged += new System.EventHandler(this.CONSCPU_CHECK_CheckedChanged);
            // 
            // TEMPCPU_CHECK
            // 
            this.TEMPCPU_CHECK.AutoSize = true;
            this.TEMPCPU_CHECK.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TEMPCPU_CHECK.CheckedState.BorderRadius = 0;
            this.TEMPCPU_CHECK.CheckedState.BorderThickness = 0;
            this.TEMPCPU_CHECK.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TEMPCPU_CHECK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEMPCPU_CHECK.ForeColor = System.Drawing.Color.White;
            this.TEMPCPU_CHECK.Location = new System.Drawing.Point(192, 128);
            this.TEMPCPU_CHECK.Name = "TEMPCPU_CHECK";
            this.TEMPCPU_CHECK.Size = new System.Drawing.Size(95, 20);
            this.TEMPCPU_CHECK.TabIndex = 13;
            this.TEMPCPU_CHECK.Text = "TEMP CPU";
            this.TEMPCPU_CHECK.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.TEMPCPU_CHECK.UncheckedState.BorderRadius = 0;
            this.TEMPCPU_CHECK.UncheckedState.BorderThickness = 0;
            this.TEMPCPU_CHECK.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.TEMPCPU_CHECK.CheckedChanged += new System.EventHandler(this.TEMPCPU_CHECK_CheckedChanged);
            // 
            // CLOCKCPU_CHECK
            // 
            this.CLOCKCPU_CHECK.AutoSize = true;
            this.CLOCKCPU_CHECK.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CLOCKCPU_CHECK.CheckedState.BorderRadius = 0;
            this.CLOCKCPU_CHECK.CheckedState.BorderThickness = 0;
            this.CLOCKCPU_CHECK.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CLOCKCPU_CHECK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLOCKCPU_CHECK.ForeColor = System.Drawing.Color.White;
            this.CLOCKCPU_CHECK.Location = new System.Drawing.Point(192, 102);
            this.CLOCKCPU_CHECK.Name = "CLOCKCPU_CHECK";
            this.CLOCKCPU_CHECK.Size = new System.Drawing.Size(100, 20);
            this.CLOCKCPU_CHECK.TabIndex = 12;
            this.CLOCKCPU_CHECK.Text = "CLOCK CPU";
            this.CLOCKCPU_CHECK.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CLOCKCPU_CHECK.UncheckedState.BorderRadius = 0;
            this.CLOCKCPU_CHECK.UncheckedState.BorderThickness = 0;
            this.CLOCKCPU_CHECK.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CLOCKCPU_CHECK.CheckedChanged += new System.EventHandler(this.CLOCKCPU_CHECK_CheckedChanged);
            // 
            // USOCPU_CHECK
            // 
            this.USOCPU_CHECK.AutoSize = true;
            this.USOCPU_CHECK.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.USOCPU_CHECK.CheckedState.BorderRadius = 0;
            this.USOCPU_CHECK.CheckedState.BorderThickness = 0;
            this.USOCPU_CHECK.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.USOCPU_CHECK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USOCPU_CHECK.ForeColor = System.Drawing.Color.White;
            this.USOCPU_CHECK.Location = new System.Drawing.Point(192, 76);
            this.USOCPU_CHECK.Name = "USOCPU_CHECK";
            this.USOCPU_CHECK.Size = new System.Drawing.Size(86, 20);
            this.USOCPU_CHECK.TabIndex = 11;
            this.USOCPU_CHECK.Text = "USO CPU";
            this.USOCPU_CHECK.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.USOCPU_CHECK.UncheckedState.BorderRadius = 0;
            this.USOCPU_CHECK.UncheckedState.BorderThickness = 0;
            this.USOCPU_CHECK.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.USOCPU_CHECK.CheckedChanged += new System.EventHandler(this.USOCPU_CHECK_CheckedChanged);
            // 
            // CPU_CHECK
            // 
            this.CPU_CHECK.AutoSize = true;
            this.CPU_CHECK.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CPU_CHECK.CheckedState.BorderRadius = 0;
            this.CPU_CHECK.CheckedState.BorderThickness = 0;
            this.CPU_CHECK.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CPU_CHECK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPU_CHECK.ForeColor = System.Drawing.Color.White;
            this.CPU_CHECK.Location = new System.Drawing.Point(21, 206);
            this.CPU_CHECK.Name = "CPU_CHECK";
            this.CPU_CHECK.Size = new System.Drawing.Size(54, 20);
            this.CPU_CHECK.TabIndex = 10;
            this.CPU_CHECK.Text = "CPU";
            this.CPU_CHECK.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CPU_CHECK.UncheckedState.BorderRadius = 0;
            this.CPU_CHECK.UncheckedState.BorderThickness = 0;
            this.CPU_CHECK.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CPU_CHECK.CheckedChanged += new System.EventHandler(this.CPU_CHECK_CheckedChanged);
            // 
            // CONSGPU_CHECK
            // 
            this.CONSGPU_CHECK.AutoSize = true;
            this.CONSGPU_CHECK.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CONSGPU_CHECK.CheckedState.BorderRadius = 0;
            this.CONSGPU_CHECK.CheckedState.BorderThickness = 0;
            this.CONSGPU_CHECK.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CONSGPU_CHECK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONSGPU_CHECK.ForeColor = System.Drawing.Color.White;
            this.CONSGPU_CHECK.Location = new System.Drawing.Point(21, 180);
            this.CONSGPU_CHECK.Name = "CONSGPU_CHECK";
            this.CONSGPU_CHECK.Size = new System.Drawing.Size(99, 20);
            this.CONSGPU_CHECK.TabIndex = 9;
            this.CONSGPU_CHECK.Text = "CONS. GPU";
            this.CONSGPU_CHECK.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CONSGPU_CHECK.UncheckedState.BorderRadius = 0;
            this.CONSGPU_CHECK.UncheckedState.BorderThickness = 0;
            this.CONSGPU_CHECK.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CONSGPU_CHECK.CheckedChanged += new System.EventHandler(this.CONSGPU_CHECK_CheckedChanged);
            // 
            // TEMPGPU_CHECK
            // 
            this.TEMPGPU_CHECK.AutoSize = true;
            this.TEMPGPU_CHECK.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TEMPGPU_CHECK.CheckedState.BorderRadius = 0;
            this.TEMPGPU_CHECK.CheckedState.BorderThickness = 0;
            this.TEMPGPU_CHECK.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TEMPGPU_CHECK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEMPGPU_CHECK.ForeColor = System.Drawing.Color.White;
            this.TEMPGPU_CHECK.Location = new System.Drawing.Point(21, 154);
            this.TEMPGPU_CHECK.Name = "TEMPGPU_CHECK";
            this.TEMPGPU_CHECK.Size = new System.Drawing.Size(99, 20);
            this.TEMPGPU_CHECK.TabIndex = 8;
            this.TEMPGPU_CHECK.Text = "TEMP. GPU";
            this.TEMPGPU_CHECK.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.TEMPGPU_CHECK.UncheckedState.BorderRadius = 0;
            this.TEMPGPU_CHECK.UncheckedState.BorderThickness = 0;
            this.TEMPGPU_CHECK.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.TEMPGPU_CHECK.CheckedChanged += new System.EventHandler(this.TEMPGPU_CHECK_CheckedChanged);
            // 
            // VRAM_CHECK
            // 
            this.VRAM_CHECK.AutoSize = true;
            this.VRAM_CHECK.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.VRAM_CHECK.CheckedState.BorderRadius = 0;
            this.VRAM_CHECK.CheckedState.BorderThickness = 0;
            this.VRAM_CHECK.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.VRAM_CHECK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VRAM_CHECK.ForeColor = System.Drawing.Color.White;
            this.VRAM_CHECK.Location = new System.Drawing.Point(21, 128);
            this.VRAM_CHECK.Name = "VRAM_CHECK";
            this.VRAM_CHECK.Size = new System.Drawing.Size(65, 20);
            this.VRAM_CHECK.TabIndex = 7;
            this.VRAM_CHECK.Text = "VRAM";
            this.VRAM_CHECK.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.VRAM_CHECK.UncheckedState.BorderRadius = 0;
            this.VRAM_CHECK.UncheckedState.BorderThickness = 0;
            this.VRAM_CHECK.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.VRAM_CHECK.CheckedChanged += new System.EventHandler(this.VRAM_CHECK_CheckedChanged);
            // 
            // USOGPU_CHECK
            // 
            this.USOGPU_CHECK.AutoSize = true;
            this.USOGPU_CHECK.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.USOGPU_CHECK.CheckedState.BorderRadius = 0;
            this.USOGPU_CHECK.CheckedState.BorderThickness = 0;
            this.USOGPU_CHECK.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.USOGPU_CHECK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USOGPU_CHECK.ForeColor = System.Drawing.Color.White;
            this.USOGPU_CHECK.Location = new System.Drawing.Point(21, 102);
            this.USOGPU_CHECK.Name = "USOGPU_CHECK";
            this.USOGPU_CHECK.Size = new System.Drawing.Size(87, 20);
            this.USOGPU_CHECK.TabIndex = 6;
            this.USOGPU_CHECK.Text = "USO GPU";
            this.USOGPU_CHECK.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.USOGPU_CHECK.UncheckedState.BorderRadius = 0;
            this.USOGPU_CHECK.UncheckedState.BorderThickness = 0;
            this.USOGPU_CHECK.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.USOGPU_CHECK.CheckedChanged += new System.EventHandler(this.USOGPU_CHECK_CheckedChanged);
            // 
            // GPU_CHECK
            // 
            this.GPU_CHECK.AutoSize = true;
            this.GPU_CHECK.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GPU_CHECK.CheckedState.BorderRadius = 0;
            this.GPU_CHECK.CheckedState.BorderThickness = 0;
            this.GPU_CHECK.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GPU_CHECK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPU_CHECK.ForeColor = System.Drawing.Color.White;
            this.GPU_CHECK.Location = new System.Drawing.Point(21, 76);
            this.GPU_CHECK.Name = "GPU_CHECK";
            this.GPU_CHECK.Size = new System.Drawing.Size(55, 20);
            this.GPU_CHECK.TabIndex = 5;
            this.GPU_CHECK.Text = "GPU";
            this.GPU_CHECK.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.GPU_CHECK.UncheckedState.BorderRadius = 0;
            this.GPU_CHECK.UncheckedState.BorderThickness = 0;
            this.GPU_CHECK.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.GPU_CHECK.CheckedChanged += new System.EventHandler(this.GPU_CHECK_CheckedChanged);
            // 
            // SCor_Label
            // 
            this.SCor_Label.BackColor = System.Drawing.Color.Transparent;
            this.SCor_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SCor_Label.ForeColor = System.Drawing.Color.White;
            this.SCor_Label.Location = new System.Drawing.Point(215, -1);
            this.SCor_Label.Name = "SCor_Label";
            this.SCor_Label.Size = new System.Drawing.Size(92, 18);
            this.SCor_Label.TabIndex = 4;
            this.SCor_Label.Text = "Selecionar Cor";
            // 
            // ColorWheel_Button
            // 
            this.ColorWheel_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ColorWheel_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ColorWheel_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ColorWheel_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ColorWheel_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ColorWheel_Button.ForeColor = System.Drawing.Color.White;
            this.ColorWheel_Button.Location = new System.Drawing.Point(192, -1);
            this.ColorWheel_Button.Name = "ColorWheel_Button";
            this.ColorWheel_Button.Size = new System.Drawing.Size(17, 17);
            this.ColorWheel_Button.TabIndex = 3;
            this.ColorWheel_Button.Click += new System.EventHandler(this.ColorWheel_Button_Click);
            // 
            // CoresAlerta_Check
            // 
            this.CoresAlerta_Check.AutoSize = true;
            this.CoresAlerta_Check.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CoresAlerta_Check.CheckedState.BorderRadius = 0;
            this.CoresAlerta_Check.CheckedState.BorderThickness = 0;
            this.CoresAlerta_Check.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CoresAlerta_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoresAlerta_Check.ForeColor = System.Drawing.Color.White;
            this.CoresAlerta_Check.Location = new System.Drawing.Point(21, -1);
            this.CoresAlerta_Check.Name = "CoresAlerta_Check";
            this.CoresAlerta_Check.Size = new System.Drawing.Size(119, 20);
            this.CoresAlerta_Check.TabIndex = 2;
            this.CoresAlerta_Check.Text = "Cores de Alerta";
            this.CoresAlerta_Check.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CoresAlerta_Check.UncheckedState.BorderRadius = 0;
            this.CoresAlerta_Check.UncheckedState.BorderThickness = 0;
            this.CoresAlerta_Check.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CoresAlerta_Check.CheckedChanged += new System.EventHandler(this.CoresAlerta_Check_CheckedChanged);
            // 
            // GRAFICOS_CHECK
            // 
            this.GRAFICOS_CHECK.AutoSize = true;
            this.GRAFICOS_CHECK.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GRAFICOS_CHECK.CheckedState.BorderRadius = 0;
            this.GRAFICOS_CHECK.CheckedState.BorderThickness = 0;
            this.GRAFICOS_CHECK.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GRAFICOS_CHECK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRAFICOS_CHECK.ForeColor = System.Drawing.Color.White;
            this.GRAFICOS_CHECK.Location = new System.Drawing.Point(192, 206);
            this.GRAFICOS_CHECK.Name = "GRAFICOS_CHECK";
            this.GRAFICOS_CHECK.Size = new System.Drawing.Size(94, 20);
            this.GRAFICOS_CHECK.TabIndex = 17;
            this.GRAFICOS_CHECK.Text = "GRÁFICOS";
            this.GRAFICOS_CHECK.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.GRAFICOS_CHECK.UncheckedState.BorderRadius = 0;
            this.GRAFICOS_CHECK.UncheckedState.BorderThickness = 0;
            this.GRAFICOS_CHECK.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.GRAFICOS_CHECK.CheckedChanged += new System.EventHandler(this.GRAFICOS_CHECK_CheckedChanged);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.PanelGeral_Config);
            this.Controls.Add(this.CloseConfig_button);
            this.Controls.Add(this.PropriedadesButton);
            this.Controls.Add(this.LogsButton);
            this.Controls.Add(this.PanelMonitoramento_Config);
            this.Controls.Add(this.MonitoramentoButton);
            this.Controls.Add(this.GeralButton);
            this.Controls.Add(this.Config_SeparatorV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Config";
            this.Text = "SysCore";
            this.Load += new System.EventHandler(this.Config_Load);
            this.PanelGeral_Config.ResumeLayout(false);
            this.PanelGeral_Config.PerformLayout();
            this.PanelMonitoramento_Config.ResumeLayout(false);
            this.PanelMonitoramento_Config.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm Confi_Form;
        private Guna.UI2.WinForms.Guna2VSeparator Config_SeparatorV;
        private Guna.UI2.WinForms.Guna2Button MonitoramentoButton;
        private Guna.UI2.WinForms.Guna2Button GeralButton;
        private Guna.UI2.WinForms.Guna2Button PropriedadesButton;
        private Guna.UI2.WinForms.Guna2Button LogsButton;
        private Guna.UI2.WinForms.Guna2ImageButton CloseConfig_button;
        private Guna.UI2.WinForms.Guna2Panel PanelGeral_Config;
        private Guna.UI2.WinForms.Guna2HtmlLabel UpdateLabel;
        private Guna.UI2.WinForms.Guna2ComboBox UpdateCombo;
        private Guna.UI2.WinForms.Guna2Button BuscarErrosButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel BuscarErrosLabel;
        private Guna.UI2.WinForms.Guna2Panel PanelMonitoramento_Config;
        private Guna.UI2.WinForms.Guna2CheckBox CoresAlerta_Check;
        private Guna.UI2.WinForms.Guna2Button ColorWheel_Button;
        private Guna.UI2.WinForms.Guna2HtmlLabel SCor_Label;
        private Guna.UI2.WinForms.Guna2CheckBox GPU_CHECK;
        private Guna.UI2.WinForms.Guna2CheckBox CONSGPU_CHECK;
        private Guna.UI2.WinForms.Guna2CheckBox TEMPGPU_CHECK;
        private Guna.UI2.WinForms.Guna2CheckBox VRAM_CHECK;
        private Guna.UI2.WinForms.Guna2CheckBox USOGPU_CHECK;
        private Guna.UI2.WinForms.Guna2CheckBox RAM_CHECK;
        private Guna.UI2.WinForms.Guna2CheckBox CONSCPU_CHECK;
        private Guna.UI2.WinForms.Guna2CheckBox TEMPCPU_CHECK;
        private Guna.UI2.WinForms.Guna2CheckBox CLOCKCPU_CHECK;
        private Guna.UI2.WinForms.Guna2CheckBox USOCPU_CHECK;
        private Guna.UI2.WinForms.Guna2CheckBox CPU_CHECK;
        private Guna.UI2.WinForms.Guna2CheckBox NomeHardware_Button;
        private Guna.UI2.WinForms.Guna2CheckBox GRAFICOS_CHECK;
    }
}