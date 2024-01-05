using MasterDevs.ChromeDevTools.Protocol.Chrome.Page;
using MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime;
using MasterDevs.ChromeDevTools.Protocol.Chrome.Target;
using System.Threading.Tasks;

namespace MasterDevs.ChromeDevTools.Protocol
{
    public sealed class CommonCommandsExecutor : ICommonCommandsExecutor
    {
        public async Task ExecuteCloseTargetCommand(IChromeSession chromeSession, string id)
        {
            await chromeSession.SendAsync(
                new CloseTargetCommand()
                {
                    TargetId = id
                }
            );
        }

        public async Task<IEvaluationResult> ExecuteEvaluateCommand(IChromeSession chromeSession, string expression)
        {
            var result = await chromeSession.SendAsync(
                new EvaluateCommand
                {
                    Expression = expression,
                    ObjectGroup = "console",
                    IncludeCommandLineAPI = true,
                    ReturnByValue = true,
                    AwaitPromise = true
                }
            );

            return new EvaluationResult(result.Result.Result.Value, result.Result.ExceptionDetails);
        }

        public async Task ExecuteNavigateCommand(IChromeSession chromeSession, string url)
        {
            await chromeSession.SendAsync(new NavigateCommand()
            {
                Url = url
            });
        }
    }
}
