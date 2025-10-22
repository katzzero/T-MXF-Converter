using System;
using System.Threading.Tasks;

namespace TMXFConverter.Core
{
    /// <summary>
    /// Implementa IProgress<double> para reportar o progresso da conversão do FFMpegCore.
    /// </summary>
    public class ProgressReporter : IProgress<double>
    {
        private readonly Action<double> _reportProgress;
        private readonly Action<string> _reportStatus;

        /// <summary>
        /// Construtor que recebe as ações de callback para atualizar a UI.
        /// </summary>
        /// <param name="reportProgress">Ação para atualizar o valor da ProgressBar (0.0 a 1.0).</param>
        /// <param name="reportStatus">Ação para atualizar a mensagem de status.</param>
        public ProgressReporter(Action<double> reportProgress, Action<string> reportStatus)
        {
            _reportProgress = reportProgress;
            _reportStatus = reportStatus;
        }

        /// <summary>
        /// Método chamado pelo FFMpegCore para reportar o progresso.
        /// </summary>
        /// <param name="value">Valor do progresso (0.0 a 1.0).</param>
        public void Report(double value)
        {
            // O FFMpegCore reporta o progresso de 0 a 100.
            // Convertemos para 0.0 a 1.0 para manter o padrão IProgress<double>.
            double percentage = value / 100.0;
            _reportProgress?.Invoke(percentage);
            _reportStatus?.Invoke($"Convertendo... {percentage:P0}");
        }

        /// <summary>
        /// Método auxiliar para reportar o status da conversão (ex: "Iniciando", "Finalizado").
        /// </summary>
        /// <param name="status">A mensagem de status.</param>
        public void ReportStatus(string status)
        {
            _reportStatus?.Invoke(status);
        }
    }
}
