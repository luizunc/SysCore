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
        public Color SelectedColor = Color.White;
        public event EventHandler<Color> ColorChanged;
        public event EventHandler<bool> CoresAlertaChanged;
        public event EventHandler<bool> NomeHardwareChanged;
        public event EventHandler<MonitoramentoSelection> MonitoramentoSelectionChanged;
        public event EventHandler<bool> GraficosChanged;
        public event EventHandler<Color> DeviceNameColorChanged;
        public event EventHandler<bool> BackgroundColorChanged;

        public class MonitoramentoSelection : EventArgs
        {
            public bool ShowCPU, ShowUSOCPU, ShowCLOCKCPU, ShowTEMPCPU, ShowCONSCPU;
            public bool ShowGPU, ShowUSOGPU, ShowVRAM, ShowTEMPGPU, ShowCONSGPU;
            public bool ShowRAM;
        }

        public Config()
        {
            InitializeComponent();
            SelectColor_Label.Visible = false;
            ButonColorWheel.Visible = false;
        }

        private void Config_Load(object sender, EventArgs e)
        {
            GeralButton.Checked = true;
            PanelGeral_Config.Visible = true;
            PanelMonitoramento_Config.Visible = false;
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
            this.Close();
        }

        private void Hotkey_Monitoramento_Click(object sender, EventArgs e)
        {

        }

        private void MonitoramentoButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MonitoramentoButton.Checked)
            {
                PanelGeral_Config.Visible = false;
                PanelMonitoramento_Config.Visible = true;
            }
        }

        private void ColorWheel_Button_Click(object sender, EventArgs e)
        {
            using (ColorDialog dlg = new ColorDialog())
            {
                dlg.Color = SelectedColor;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    SelectedColor = dlg.Color;
                    // Notifica apenas a mudança de cor dos nomes dos dispositivos
                    DeviceNameColorChanged?.Invoke(this, SelectedColor);
                }
            }
        }

        private void CoresAlerta_Check_CheckedChanged(object sender, EventArgs e)
        {
            CoresAlertaChanged?.Invoke(this, CoresAlerta_Check.Checked);
        }

        private void NomeHardware_Button_CheckedChanged(object sender, EventArgs e)
        {
            NomeHardwareChanged?.Invoke(this, NomeHardware_Button.Checked);
        }

        private void NotifyMonitoramentoSelection()
        {
            MonitoramentoSelectionChanged?.Invoke(this, new MonitoramentoSelection
            {
                ShowCPU = CPU_CHECK.Checked,
                ShowUSOCPU = USOCPU_CHECK.Checked,
                ShowCLOCKCPU = CLOCKCPU_CHECK.Checked,
                ShowTEMPCPU = TEMPCPU_CHECK.Checked,
                ShowCONSCPU = CONSCPU_CHECK.Checked,
                ShowGPU = GPU_CHECK.Checked,
                ShowUSOGPU = USOGPU_CHECK.Checked,
                ShowVRAM = VRAM_CHECK.Checked,
                ShowTEMPGPU = TEMPGPU_CHECK.Checked,
                ShowCONSGPU = CONSGPU_CHECK.Checked,
                ShowRAM = RAM_CHECK.Checked
            });
        }

        private void RAM_CHECK_CheckedChanged(object sender, EventArgs e) => NotifyMonitoramentoSelection();
        private void CONSCPU_CHECK_CheckedChanged(object sender, EventArgs e) => NotifyMonitoramentoSelection();
        private void TEMPCPU_CHECK_CheckedChanged(object sender, EventArgs e) => NotifyMonitoramentoSelection();
        private void CLOCKCPU_CHECK_CheckedChanged(object sender, EventArgs e) => NotifyMonitoramentoSelection();
        private void USOCPU_CHECK_CheckedChanged(object sender, EventArgs e) => NotifyMonitoramentoSelection();
        private void CPU_CHECK_CheckedChanged(object sender, EventArgs e) => NotifyMonitoramentoSelection();
        private void CONSGPU_CHECK_CheckedChanged(object sender, EventArgs e) => NotifyMonitoramentoSelection();
        private void TEMPGPU_CHECK_CheckedChanged(object sender, EventArgs e) => NotifyMonitoramentoSelection();
        private void VRAM_CHECK_CheckedChanged(object sender, EventArgs e) => NotifyMonitoramentoSelection();
        private void USOGPU_CHECK_CheckedChanged(object sender, EventArgs e) => NotifyMonitoramentoSelection();
        private void GPU_CHECK_CheckedChanged(object sender, EventArgs e) => NotifyMonitoramentoSelection();
        private void GRAFICOS_CHECK_CheckedChanged(object sender, EventArgs e)
        {
            GraficosChanged?.Invoke(this, GRAFICOS_CHECK.Checked);
        }

        private void SCor_Label_Click(object sender, EventArgs e)
        {

        }

        private void BackgroundColor_Check_CheckedChanged(object sender, EventArgs e)
        {
            ButonColorWheel.Visible = BackgroundColor_Check.Checked;
            SelectColor_Label.Visible = BackgroundColor_Check.Checked;
            BackgroundColorChanged?.Invoke(this, BackgroundColor_Check.Checked);
        }

        private void ButonColorWheel_Click(object sender, EventArgs e)
        {
            using (ColorDialog dlg = new ColorDialog())
            {
                dlg.Color = SelectedColor;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    SelectedColor = dlg.Color;
                    ButonColorWheel.FillColor = SelectedColor;
                    ColorChanged?.Invoke(this, SelectedColor);
                }
            }
        }

        private void SelectColor_Label_Click(object sender, EventArgs e)
        {
            using (ColorDialog dlg = new ColorDialog())
            {
                dlg.Color = SelectedColor;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    SelectedColor = dlg.Color;
                    // Não preencher o fundo do label
                    ColorChanged?.Invoke(this, SelectedColor);
                }
            }
        }

        public bool IsBackgroundColorChecked => BackgroundColor_Check.Checked;
    }
}
