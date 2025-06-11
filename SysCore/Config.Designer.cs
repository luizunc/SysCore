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
            this.PanelMonitoramento_Config = new Guna.UI2.WinForms.Guna2Panel();
            this.BuscarErrosButton = new Guna.UI2.WinForms.Guna2Button();
            this.BuscarErrosLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.UpdateCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.UpdateLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Hotkey_Monitoramento = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.AtalhoMonitoramento = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.MonitoramentoButton.Click += new System.EventHandler(this.MonitoramentoButton_Click);
            this.MonitoramentoButton.CheckedChanged += new System.EventHandler(this.MonitoramentoButton_CheckedChanged);
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
            this.PanelGeral_Config.Controls.Add(this.PanelMonitoramento_Config);
            this.PanelGeral_Config.Controls.Add(this.BuscarErrosButton);
            this.PanelGeral_Config.Controls.Add(this.BuscarErrosLabel);
            this.PanelGeral_Config.Controls.Add(this.UpdateCombo);
            this.PanelGeral_Config.Controls.Add(this.UpdateLabel);
            this.PanelGeral_Config.Location = new System.Drawing.Point(168, 50);
            this.PanelGeral_Config.Name = "PanelGeral_Config";
            this.PanelGeral_Config.Size = new System.Drawing.Size(320, 288);
            this.PanelGeral_Config.TabIndex = 12;
            // 
            // PanelMonitoramento_Config
            // 
            this.PanelMonitoramento_Config.Controls.Add(this.AtalhoMonitoramento);
            this.PanelMonitoramento_Config.Controls.Add(this.Hotkey_Monitoramento);
            this.PanelMonitoramento_Config.Location = new System.Drawing.Point(168, 50);
            this.PanelMonitoramento_Config.Name = "PanelMonitoramento_Config";
            this.PanelMonitoramento_Config.Size = new System.Drawing.Size(320, 288);
            this.PanelMonitoramento_Config.TabIndex = 13;
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
            // Hotkey_Monitoramento
            // 
            this.Hotkey_Monitoramento.BackColor = System.Drawing.Color.Transparent;
            this.Hotkey_Monitoramento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hotkey_Monitoramento.ForeColor = System.Drawing.Color.White;
            this.Hotkey_Monitoramento.Location = new System.Drawing.Point(44, 0);
            this.Hotkey_Monitoramento.Name = "Hotkey_Monitoramento";
            this.Hotkey_Monitoramento.Size = new System.Drawing.Size(98, 18);
            this.Hotkey_Monitoramento.TabIndex = 0;
            this.Hotkey_Monitoramento.Text = "Tecla de Atalho";
            this.Hotkey_Monitoramento.Click += new System.EventHandler(this.Hotkey_Monitoramento_Click);
            // 
            // AtalhoMonitoramento
            // 
            this.AtalhoMonitoramento.BorderColor = System.Drawing.Color.Transparent;
            this.AtalhoMonitoramento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AtalhoMonitoramento.DefaultText = "";
            this.AtalhoMonitoramento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AtalhoMonitoramento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AtalhoMonitoramento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AtalhoMonitoramento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AtalhoMonitoramento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AtalhoMonitoramento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AtalhoMonitoramento.ForeColor = System.Drawing.Color.Transparent;
            this.AtalhoMonitoramento.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AtalhoMonitoramento.Location = new System.Drawing.Point(15, 0);
            this.AtalhoMonitoramento.Name = "AtalhoMonitoramento";
            this.AtalhoMonitoramento.PlaceholderForeColor = System.Drawing.Color.Black;
            this.AtalhoMonitoramento.PlaceholderText = "";
            this.AtalhoMonitoramento.SelectedText = "";
            this.AtalhoMonitoramento.Size = new System.Drawing.Size(23, 18);
            this.AtalhoMonitoramento.TabIndex = 1;
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
            this.Controls.Add(this.MonitoramentoButton);
            this.Controls.Add(this.GeralButton);
            this.Controls.Add(this.Config_SeparatorV);
            this.Controls.Add(this.PanelMonitoramento_Config);
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
        private Guna.UI2.WinForms.Guna2TextBox AtalhoMonitoramento;
        private Guna.UI2.WinForms.Guna2HtmlLabel Hotkey_Monitoramento;
    }
}