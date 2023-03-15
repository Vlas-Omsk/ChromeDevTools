using System.Threading.Tasks;

namespace MasterDevs.ChromeDevTools.Protocol
{
    public interface ICommonCommandsExecutor
    {
        Task ExecuteCloseTargetCommand(IChromeSession chromeSession, string id);
        Task<IEvaluationResult> ExecuteEvaluateCommand(IChromeSession chromeSession, string expression);
        Task ExecuteNavigateCommand(IChromeSession chromeSession, string url);
    }
}
