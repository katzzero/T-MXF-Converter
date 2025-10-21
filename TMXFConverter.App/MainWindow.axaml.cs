using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
using System.IO;
using System.Threading.Tasks;
using TMXFConverter.Core;
using FFMpegCore;
using Avalonia.Platform.Storage;
using System.Linq;

namespace TMXFConverter.App
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.AttachEvents();
            // Inicialização de valores padrão
            TxtOutFilename.Text = "MXF_CONVERT";
        }

        private void AttachEvents()
        {
            BtnLoadMXF.Click += BtnLoadMXF_Click;
            BtnSelectOutPath.Click += BtnSelectOutPath_Click;
            BtnConvert.Click += BtnConvert_Click;
        }

        private async void BtnLoadMXF_Click(object sender, RoutedEventArgs e)
        {
            // 1. Abrir diálogo de arquivo
            var topLevel = TopLevel.GetTopLevel(this);
            if (topLevel == null) return;

            var files = await topLevel.StorageProvider.OpenFilePickerAsync(new FilePickerOpenOptions
            {
                Title = "Selecione o Arquivo MXF",
                AllowMultiple = false,
                FileTypeFilter = new[]
                {
                    new FilePickerFileType("MXF Files") { Patterns = new[] { "*.mxf" } }
                }
            });

            var mxfPath = files.FirstOrDefault()?.Path.LocalPath;
            if (string.IsNullOrEmpty(mxfPath)) return;

            TxtMXFpath.Text = mxfPath;
            TxtFFoutput.Text += $"{DateTime.Now:HH:mm:ss} Arquivo selecionado: {mxfPath}{Environment.NewLine}";

            // 2. Processar o arquivo MXF usando a API do FFMpegCore
            var result = await MXFProcessor.ProcessMXFFile(mxfPath);

            // 3. Atualizar a UI com os metadados
            if (result.Success)
            {
                LblTimeCode.Text = result.TimeCode;
                LblFrameRate.Text = result.FrameRate;
                LblVideoCodec.Text = result.VideoCodec;
                LblAudioCodec.Text = result.AudioCodec;
                LblSampleRate.Text = result.SampleRate;
                LblDuration.Text = result.Duration;

                TxtFFoutput.Text += $"{DateTime.Now:HH:mm:ss} Análise de metadados concluída com sucesso.{Environment.NewLine}";
                TxtFFoutput.Text += $"{DateTime.Now:HH:mm:ss} FR: {result.FrameRate}, Codec: {result.VideoCodec}{Environment.NewLine}";
            }
            else
            {
                TxtFFoutput.Text += $"{DateTime.Now:HH:mm:ss} ERRO na análise: {result.ErrorMessage}{Environment.NewLine}";
                // Limpar metadados em caso de erro
                LblTimeCode.Text = LblFrameRate.Text = LblVideoCodec.Text = LblAudioCodec.Text = LblSampleRate.Text = LblDuration.Text = "## Error ##";
            }
        }

        private async void BtnSelectOutPath_Click(object sender, RoutedEventArgs e)
        {
            var topLevel = TopLevel.GetTopLevel(this);
            if (topLevel == null) return;

            var folder = await topLevel.StorageProvider.OpenFolderPickerAsync(new FolderPickerOpenOptions
            {
                Title = "Selecione o Diretório de Saída",
                AllowMultiple = false
            });

            var outPath = folder.FirstOrDefault()?.Path.LocalPath;
            if (!string.IsNullOrEmpty(outPath))
            {
                TxtOutPath.Text = outPath;
                TxtFFoutput.Text += $"{DateTime.Now:HH:mm:ss} Diretório de saída selecionado: {outPath}{Environment.NewLine}";
            }
        }

        private async void BtnConvert_Click(object sender, RoutedEventArgs e)
        {
            // 1. Validação de campos
            if (string.IsNullOrEmpty(TxtMXFpath.Text) || string.IsNullOrEmpty(TxtOutPath.Text))
            {
                TxtFFoutput.Text += $"{DateTime.Now:HH:mm:ss} ERRO: Selecione o arquivo MXF e o diretório de saída.{Environment.NewLine}";
                return;
            }

            // 2. Mapeamento da UI para o DTO de Opções
            var options = new ConversionOptions
            {
                InputPath = TxtMXFpath.Text,
                OutputDirectory = TxtOutPath.Text,
                OutputFilename = TxtOutFilename.Text,
                NameDate = DateTime.Now.ToString("dd-MM-yyyy-HH-mm"),
                DetectedFrameRate = LblFrameRate.Text,

                // Codecs
                IsDNxHD = RdbDNxHD.IsChecked ?? false,
                IsProRes = RdbProRes.IsChecked ?? false,
                IsH264 = RdbH264.IsChecked ?? false,
                IsWAV = RdbWAV.IsChecked ?? false,
                IsCustom = ChkCustom.IsChecked ?? false,
                CustomCommand = TxtCustom.Text,

                // Resolução
                Is1080p = Rdb1080.IsChecked ?? false,
                Is720p = Rdb720.IsChecked ?? false,
                // ... outras resoluções

                // Opções Avançadas
                CorrectFrameRate = ChkCorrect.IsChecked ?? false,
                UseHWaccel = ChkHWaccel.IsChecked ?? false,
                UseReport = ChkReport.IsChecked ?? false,
                UseTCBurn = ChkTCBurn.IsChecked ?? false,
                TimeCode = LblTimeCode.Text,

                // Áudio e Sample Rate (Simplificado)
                AudioPCM24 = true, // Exemplo
                SR48 = true // Exemplo
            };

            // 3. Construção dos Argumentos (Fluent API)
            var arguments = FFmpegCommandBuilder.BuildConversionArguments(options);

            // 4. Execução da Conversão (FFMpegCore)
            try
            {
                TxtFFoutput.Text += $"{DateTime.Now:HH:mm:ss} Iniciando conversão...{Environment.NewLine}";
                
                // O FFMpegCore precisa dos binários FFmpeg configurados.
                // Em um projeto real, isso seria feito na inicialização do App.
                // Por simplicidade, vamos usar o método de execução assíncrona.

                var success = await FFMpeg.Conversions.StartUnsafeForProbingAsync(arguments);

                if (success)
                {
                    TxtFFoutput.Text += $"{DateTime.Now:HH:mm:ss} CONVERSÃO CONCLUÍDA COM SUCESSO!{Environment.NewLine}";
                }
                else
                {
                    TxtFFoutput.Text += $"{DateTime.Now:HH:mm:ss} ERRO: Conversão falhou. Verifique o log detalhado.{Environment.NewLine}";
                }
            }
            catch (Exception ex)
            {
                TxtFFoutput.Text += $"{DateTime.Now:HH:mm:ss} ERRO FATAL: {ex.Message}{Environment.NewLine}";
            }
        }
    }
}
