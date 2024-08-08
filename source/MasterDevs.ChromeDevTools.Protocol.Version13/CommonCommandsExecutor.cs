using MasterDevs.ChromeDevTools.Protocol.Chrome.Page;
using MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime;
using MasterDevs.ChromeDevTools.Protocol.Chrome.Target;
using System.Threading;
using System.Threading.Tasks;

namespace MasterDevs.ChromeDevTools.Protocol
{
    public sealed class CommonCommandsExecutor : ICommonCommandsExecutor
    {
        public Task ExecuteCloseTargetCommand(IChromeSession chromeSession, string id, CancellationToken cancellationToken)
        {
            return chromeSession.SendAsync(
                new CloseTargetCommand()
                {
                    TargetId = id
                },
                cancellationToken
            );
        }

        public async Task<IEvaluationResult> ExecuteEvaluateCommand(IChromeSession chromeSession, string expression, CancellationToken cancellationToken)
        {
            var result = await chromeSession.SendAsync(
                new EvaluateCommand
                {
                    Expression = expression,
                    ObjectGroup = "console",
                    IncludeCommandLineAPI = true,
                    ReturnByValue = true,
                    AwaitPromise = true
                },
                cancellationToken
            ).ConfigureAwait(false);

            return new EvaluationResult(result.Result.Result.Value, result.Result.ExceptionDetails);
        }

        public Task ExecuteNavigateCommand(IChromeSession chromeSession, string url, CancellationToken cancellationToken)
        {
            return chromeSession.SendAsync(new NavigateCommand()
            {
                Url = url
            }, cancellationToken);
        }
    }
}
