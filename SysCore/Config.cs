using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysCore
{
    public partial class Config : Form
    {
        public Keys HotkeyMonitoramento = Keys.None;

        public Config()
        {
            InitializeComponent();
        }

        private void Config_Load(object sender, EventArgs e)
        {
            // Marcar o GeralButton automaticamente
            GeralButton.Checked = true;
            
            // Mostrar apenas o PanelGeral_Config
            PanelGeral_Config.Visible = true;
            AtalhoMonitoramento.KeyDown += AtalhoMonitoramento_KeyDown;
            AtalhoMonitoramento.ReadOnly = true;
        }

        private void Geral_Click(object sender, EventArgs e)
        {
            PanelGeral_Config.Visible = true;
            PanelMonitoramento_Config.Visible = false;
        }

        private void MonitoramentoButton_Click(object sender, EventArgs e)
        {
            PanelGeral_Config.Visible = false;
            PanelMonitoramento_Config.Visible = true;
        }

        private void CloseConfig_button_Click(object sender, EventArgs e)
        {
            // Atualiza a hotkey global ao fechar a configuração
            if (Owner is SysCore_Form mainForm)
            {
                mainForm.RegisterOverlayHotkey();
            }
            this.Close();
        }

        private void Hotkey_Monitoramento_Click(object sender, EventArgs e)
        {

        }

        private void AtalhoMonitoramento_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            HotkeyMonitoramento = e.KeyCode;
            AtalhoMonitoramento.Text = HotkeyMonitoramento.ToString();
        }

        private void MonitoramentoButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MonitoramentoButton.Checked)
            {
                PanelGeral_Config.Visible = false;
                PanelMonitoramento_Config.Visible = true;
            }
        }
    }
}
