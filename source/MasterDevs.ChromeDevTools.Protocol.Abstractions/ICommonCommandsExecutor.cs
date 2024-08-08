using System.Threading;
using System.Threading.Tasks;

namespace MasterDevs.ChromeDevTools.Protocol
{
    public interface ICommonCommandsExecutor
    {
        Task ExecuteCloseTargetCommand(IChromeSession chromeSession, string id, CancellationToken cancellationToken);
        Task<IEvaluationResult> ExecuteEvaluateCommand(IChromeSession chromeSession, string expression, CancellationToken cancellationToken);
        Task ExecuteNavigateCommand(IChromeSession chromeSession, string url, CancellationToken cancellationToken);
    }
}
