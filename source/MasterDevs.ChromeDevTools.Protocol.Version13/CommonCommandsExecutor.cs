using MasterDevs.ChromeDevTools.Protocol.Chrome.Page;
using MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime;
using MasterDevs.ChromeDevTools.Protocol.Chrome.Target;
using System.Threading.Tasks;

namespace MasterDevs.ChromeDevTools.Protocol
{
    public sealed class CommonCommandsExecutor : ICommonCommandsExecutor
    {
        public Task ExecuteCloseTargetCommand(IChromeSession chromeSession, string id)
        {
            return chromeSession.SendAsync(
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
            ).ConfigureAwait(false);

            return new EvaluationResult(result.Result.Result.Value, result.Result.ExceptionDetails);
        }

        public Task ExecuteNavigateCommand(IChromeSession chromeSession, string url)
        {
            return chromeSession.SendAsync(new NavigateCommand()
            {
                Url = url
            });
        }
    }
}
