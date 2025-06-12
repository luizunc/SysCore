//  ######   ####     ##  ##   ######   #####
//  ##       ## ##    ##  ##       ##   ##  ##
//  ##       ##  ##   ##  ##      ##    ##  ##
//  ####     ##  ##   ##  ##     ##     #####
//  ##       ##  ##   ##  ##    ##      ##
//  ##       ## ##    ##  ##   ##       ##
//  ######   ####      ####    ######   ##

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.IO;
using System.Management;

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

        private bool isStressTestRunning = false;
        private CancellationTokenSource stressTestCancellation;
        private bool isNetworkTestRunning = false;
        private CancellationTokenSource networkTestCancellation;

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
            PanelBenchmark_Config.Visible = false;
            PanelSobre_Config.Visible = false;
        }

        private void Geral_Click(object sender, EventArgs e)
        {
            PanelGeral_Config.Visible = true;
            PanelMonitoramento_Config.Visible = false;
            PanelBenchmark_Config.Visible = false;
        }

        private void MonitoramentoButton_Click(object sender, EventArgs e)
        {
            PanelGeral_Config.Visible = false;
            PanelMonitoramento_Config.Visible = true;
            PanelBenchmark_Config.Visible = false;
        }

        private void LogsButton_Click(object sender, EventArgs e)
        {
            PanelGeral_Config.Visible = false;
            PanelMonitoramento_Config.Visible = false;
            PanelBenchmark_Config.Visible = true;
        }

        private void LogsButton_CheckedChanged(object sender, EventArgs e)
        {
            if (BenchmarkButton.Checked)
            {
                PanelGeral_Config.Visible = false;
                PanelMonitoramento_Config.Visible = false;
                PanelBenchmark_Config.Visible = true;
            }
        }

        private void CloseConfig_button_Click(object sender, EventArgs e)
        {
            this.Hide();
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
                    ColorChanged?.Invoke(this, SelectedColor);
                }
            }
        }

        public bool IsBackgroundColorChecked => BackgroundColor_Check.Checked;

        private void PanelBenchmark_Config_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void StressCPU_Button_Click(object sender, EventArgs e)
        {
            if (isStressTestRunning)
            {
                var result = MessageBox.Show("Deseja cancelar o teste de stress da CPU?",
                    "Cancelar Teste", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    stressTestCancellation?.Cancel();
                    return;
                }
                return;
            }

            var startResult = MessageBox.Show("O teste de stress da CPU pode causar lentidão no sistema. Deseja continuar?",
                "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (startResult == DialogResult.Yes)
            {
                isStressTestRunning = true;
                stressTestCancellation = new CancellationTokenSource();
                StressCPU_Button.FillColor = Color.Green;
                StressCPU_Button.Text = "Cancelar";

                try
                {
                    await Task.Run(() => RunCPUStressTest(stressTestCancellation.Token));
                }
                catch (OperationCanceledException)
                {
                    MessageBox.Show("Teste de stress da CPU cancelado!", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    isStressTestRunning = false;
                    StressCPU_Button.FillColor = Color.White;
                    StressCPU_Button.Text = "Render";
                }
            }
        }

        private async void StressGPU_Button_Click(object sender, EventArgs e)
        {
            if (isStressTestRunning)
            {
                var result = MessageBox.Show("Deseja cancelar o teste de stress da GPU?",
                    "Cancelar Teste", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    stressTestCancellation?.Cancel();
                    return;
                }
                return;
            }

            var startResult = MessageBox.Show("O teste de stress da GPU pode causar lentidão no sistema. Deseja continuar?",
                "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (startResult == DialogResult.Yes)
            {
                isStressTestRunning = true;
                stressTestCancellation = new CancellationTokenSource();
                StressGPU_Button.FillColor = Color.Green;
                StressGPU_Button.Text = "Cancelar";

                try
                {
                    await Task.Run(() => RunGPUStressTest(stressTestCancellation.Token));
                }
                catch (OperationCanceledException)
                {
                    MessageBox.Show("Teste de stress da GPU cancelado!", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    isStressTestRunning = false;
                    StressGPU_Button.FillColor = Color.White;
                    StressGPU_Button.Text = "Render";
                }
            }
        }

        private void RunCPUStressTest(CancellationToken cancellationToken)
        {
            int numThreads = Environment.ProcessorCount;
            var tasks = new List<Task>();
            var stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < numThreads; i++)
            {
                tasks.Add(Task.Run(() =>
                {
                    while (!cancellationToken.IsCancellationRequested && stopwatch.Elapsed.TotalSeconds < 15)
                    {
                        double result = 0;
                        for (int j = 0; j < 1000000; j++)
                        {
                            result += Math.Sqrt(j) * Math.Sin(j) * Math.Cos(j);
                        }
                    }
                }, cancellationToken));
            }

            Task.WaitAll(tasks.ToArray());
            stopwatch.Stop();
            //
            // pontuação baseada no tempo e número de operações
            //
            double cpuScore = (numThreads * 1000000 * 15) / stopwatch.Elapsed.TotalSeconds;
            SaveBenchmarkResults(cpuScore, 0);
            //
            // resultado final
            //
            this.Invoke((MethodInvoker)delegate
            {
                MessageBox.Show(
                    $"Resultado do teste de stress da CPU:\n\n" +
                    $"Pontuação: {cpuScore:F2}\n" +
                    $"Tempo: {stopwatch.Elapsed.TotalSeconds:F1} segundos\n" +
                    $"Núcleos utilizados: {numThreads}",
                    "Teste de Stress Concluído",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            });
        }

        private void RunGPUStressTest(CancellationToken cancellationToken)
        {
            using (var form = new Form())
            {
                form.Size = new Size(800, 600);
                form.StartPosition = FormStartPosition.CenterScreen;
                form.FormBorderStyle = FormBorderStyle.None;
                form.TopMost = true;

                var pictureBox = new PictureBox
                {
                    Dock = DockStyle.Fill,
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                form.Controls.Add(pictureBox);

                var stopwatch = new System.Diagnostics.Stopwatch();
                stopwatch.Start();
                //
                // start
                //
                form.Show();
                int frameCount = 0;

                while (!cancellationToken.IsCancellationRequested && stopwatch.Elapsed.TotalSeconds < 15)
                {
                    Bitmap bitmap = new Bitmap(800, 600);
                    using (var g = Graphics.FromImage(bitmap))
                    {
                        g.Clear(Color.Black);
                        var random = new Random();
                        for (int i = 0; i < 1000; i++)
                        {
                            var color = Color.FromArgb(
                                random.Next(256),
                                random.Next(256),
                                random.Next(256)
                            );
                            var brush = new SolidBrush(color);
                            var x = random.Next(800);
                            var y = random.Next(600);
                            var size = random.Next(20, 100);
                            g.FillEllipse(brush, x, y, size, size);
                            brush.Dispose();
                        }
                    }

                    form.Invoke((MethodInvoker)delegate
                    {
                        if (pictureBox.Image != null)
                            pictureBox.Image.Dispose();
                        pictureBox.Image = bitmap;
                    });

                    frameCount++;
                    Application.DoEvents();
                }

                stopwatch.Stop();
                form.Close();
                //
                // pontuação baseada no FPS
                //
                double gpuScore = frameCount / stopwatch.Elapsed.TotalSeconds;
                SaveBenchmarkResults(0, gpuScore);
                //
                // resultado final
                //
                this.Invoke((MethodInvoker)delegate
                {
                    MessageBox.Show(
                        $"Resultado do teste de stress da GPU:\n\n" +
                        $"Pontuação: {gpuScore:F2} FPS\n" +
                        $"Tempo: {stopwatch.Elapsed.TotalSeconds:F1} segundos\n" +
                        $"Total de frames: {frameCount}",
                        "Teste de Stress Concluído",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                });
            }
        }

        private void ExportLogs_Button_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Selecione a pasta para salvar os logs";

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string selectedPath = folderDialog.SelectedPath;
                        string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                        string logFileName = $"SysCore_Logs_{timestamp}.txt";
                        string fullPath = Path.Combine(selectedPath, logFileName);

                        using (StreamWriter writer = new StreamWriter(fullPath))
                        {
                            writer.WriteLine("=== SysCore Logs ===");
                            writer.WriteLine($"Data e Hora: {DateTime.Now}");
                            writer.WriteLine();
                            //
                            // LOGS - informações do sistema
                            //
                            writer.WriteLine("=== Informações do Sistema ===");
                            writer.WriteLine($"Sistema Operacional: {Environment.OSVersion}");
                            writer.WriteLine($"Processador: {Environment.ProcessorCount} núcleos");
                            writer.WriteLine($"Memória Total: {GetTotalPhysicalMemory() / (1024 * 1024)} MB");
                            writer.WriteLine();
                            //
                            // LOGS - resultados de benchmark
                            //
                            if (File.Exists("benchmark_results.txt"))
                            {
                                writer.WriteLine("=== Resultados de Benchmark ===");
                                string[] benchmarkResults = File.ReadAllLines("benchmark_results.txt");
                                foreach (string line in benchmarkResults)
                                {
                                    writer.WriteLine(line);
                                }
                                writer.WriteLine();
                            }
                            //
                            // LOGS - resultados de rede
                            //
                            if (File.Exists("network_test_results.txt"))
                            {
                                writer.WriteLine("=== Resultados de Teste de Rede ===");
                                string[] networkResults = File.ReadAllLines("network_test_results.txt");
                                foreach (string line in networkResults)
                                {
                                    writer.WriteLine(line);
                                }
                                writer.WriteLine();
                            }
                        }

                        MessageBox.Show(
                            $"Logs exportados com sucesso!\nLocal: {fullPath}",
                            "Exportação Concluída",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            $"Erro ao exportar logs: {ex.Message}",
                            "Erro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
            }
        }

        private long GetTotalPhysicalMemory()
        {
            try
            {
                using (var searcher = new System.Management.ManagementObjectSearcher("SELECT TotalVisibleMemorySize FROM Win32_OperatingSystem"))
                {
                    foreach (var obj in searcher.Get())
                    {
                        return Convert.ToInt64(obj["TotalVisibleMemorySize"]) * 1024;
                    }
                }
            }
            catch
            {
                return 0;
            }
            return 0;
        }

        private void ExportLogs_Label_Click(object sender, EventArgs e)
        {

        }

        private void WifiTest_Label_Click(object sender, EventArgs e)
        {

        }

        private async void WifiTest_Button_Click(object sender, EventArgs e)
        {
            if (isNetworkTestRunning)
            {
                var result = MessageBox.Show("Deseja cancelar o teste de rede?",
                    "Cancelar Teste", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    networkTestCancellation?.Cancel();
                    return;
                }
                return;
            }

            var startResult = MessageBox.Show("O teste de rede irá medir a velocidade de download e upload. Deseja continuar?",
                "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (startResult == DialogResult.Yes)
            {
                isNetworkTestRunning = true;
                networkTestCancellation = new CancellationTokenSource();
                WifiTest_Button.FillColor = Color.Green;
                WifiTest_Button.Text = "Cancelar";

                try
                {
                    await Task.Run(() => RunNetworkSpeedTest(networkTestCancellation.Token));
                }
                catch (OperationCanceledException)
                {
                    MessageBox.Show("Teste de rede cancelado!", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao realizar o teste de rede: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    isNetworkTestRunning = false;
                    WifiTest_Button.FillColor = Color.White;
                    WifiTest_Button.Text = "Render";
                }
            }
        }

        private void SaveBenchmarkResults(double cpuScore, double gpuScore)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("benchmark_results.txt"))
                {
                    writer.WriteLine($"Data e Hora do Teste: {DateTime.Now}");
                    writer.WriteLine($"Pontuação CPU: {cpuScore:F2}");
                    writer.WriteLine($"Pontuação GPU: {gpuScore:F2}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar resultados do benchmark: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveNetworkTestResults(double downloadSpeed, double uploadSpeed)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("network_test_results.txt"))
                {
                    writer.WriteLine($"Data e Hora do Teste: {DateTime.Now}");
                    writer.WriteLine($"Velocidade de Download: {downloadSpeed:F2} Mbps");
                    writer.WriteLine($"Velocidade de Upload: {uploadSpeed:F2} Mbps");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar resultados do teste de rede: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RunNetworkSpeedTest(CancellationToken cancellationToken)
        {
            try
            {   //
                // teste de rede
                //
                string[] downloadUrls = new string[]
                {
                    "https://speed.cloudflare.com/__down?bytes=25000000",
                    "https://speed.cloudflare.com/__down?bytes=25000000",
                    "https://speed.cloudflare.com/__down?bytes=25000000"
                };

                string[] uploadUrls = new string[]
                {
                    "https://speed.cloudflare.com/__up",
                    "https://speed.cloudflare.com/__up",
                    "https://speed.cloudflare.com/__up"
                };

                // download
                double totalDownloadSpeed = 0;
                int downloadTests = 0;

                foreach (string url in downloadUrls)
                {
                    if (cancellationToken.IsCancellationRequested) return;

                    using (var client = new WebClient())
                    {
                        var startTime = DateTime.Now;
                        var data = client.DownloadData(url);
                        var endTime = DateTime.Now;

                        var duration = (endTime - startTime).TotalSeconds;
                        var speedMbps = (data.Length * 8) / (duration * 1000000.0);
                        totalDownloadSpeed += speedMbps;
                        downloadTests++;

                        this.Invoke((MethodInvoker)delegate
                        {
                            WifiTest_Button.Text = $"Download: {speedMbps:F2} Mbps";
                        });
                    }
                }

                double avgDownloadSpeed = totalDownloadSpeed / downloadTests;

                // upload
                double totalUploadSpeed = 0;
                int uploadTests = 0;

                foreach (string url in uploadUrls)
                {
                    if (cancellationToken.IsCancellationRequested) return;

                    using (var client = new WebClient())
                    {
                        byte[] data = new byte[1024 * 1024];
                        new Random().NextBytes(data);

                        var startTime = DateTime.Now;
                        var response = client.UploadData(url, data);
                        var endTime = DateTime.Now;

                        var duration = (endTime - startTime).TotalSeconds;
                        var speedMbps = (data.Length * 8) / (duration * 1000000.0);
                        totalUploadSpeed += speedMbps;
                        uploadTests++;

                        this.Invoke((MethodInvoker)delegate
                        {
                            WifiTest_Button.Text = $"Upload: {speedMbps:F2} Mbps";
                        });
                    }
                }

                double avgUploadSpeed = totalUploadSpeed / uploadTests;

                SaveNetworkTestResults(avgDownloadSpeed, avgUploadSpeed);

                this.Invoke((MethodInvoker)delegate
                {
                    MessageBox.Show(
                        $"Resultado do teste de rede:\n\n" +
                        $"Download: {avgDownloadSpeed:F2} Mbps\n" +
                        $"Upload: {avgUploadSpeed:F2} Mbps",
                        "Teste de Rede Concluído",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                });
            }
            catch (WebException ex)
            {
                throw new Exception("Erro de conexão: " + ex.Message);
            }
        }

        private void StressGPU_Label_Click(object sender, EventArgs e)
        {

        }

        private void StressCPU_Label_Click(object sender, EventArgs e)
        {

        }

        private void GitHubRed_Button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/luizunc/SysCore");
        }

        private void PropriedadesButton_CheckedChanged(object sender, EventArgs e)
        {
            if (PropriedadesButton.Checked)
            {
                PanelGeral_Config.Visible = false;
                PanelMonitoramento_Config.Visible = false;
                PanelBenchmark_Config.Visible = false;
                PanelSobre_Config.Visible = true;
            }
            else
            {
                PanelSobre_Config.Visible = false;
            }
        }

        private void Integrantes_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PanelSobre_Config_Paint(object sender, PaintEventArgs e)
        {

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