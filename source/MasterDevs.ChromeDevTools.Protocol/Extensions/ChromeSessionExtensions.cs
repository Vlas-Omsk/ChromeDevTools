using MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime;
using System.Threading.Tasks;
using System.Threading;
using System;
using MasterDevs.ChromeDevTools.Protocol.Chrome.Target;

namespace MasterDevs.ChromeDevTools.Protocol
{
    public static class ChromeSessionExtensions
    {
        public static async Task Close(this IChromeSession self)
        {
            await self.SendAsync(new CloseTargetCommand()
            {
                TargetId = self.Id
            });
        }

        public static void WaitWhile(this IChromeSession chromeSession, string expression, TimeSpan? timeout = null)
        {
            var startTime = DateTime.Now;

            SpinWait.SpinUntil(
                () =>
                {
                    if (timeout.HasValue && DateTime.Now.Subtract(startTime) > timeout.Value)
                        throw new TimeoutException();

                    var result = chromeSession.SendAsync(new EvaluateCommand
                    {
                        Expression = expression,
                        ObjectGroup = "console",
                        IncludeCommandLineAPI = true,
                        ReturnByValue = true,
                    }).GetAwaiter().GetResult().Result.Result.Value;

                    var boolResult = result is bool x ? x : result != null;

                    if (!boolResult)
                        Thread.Sleep(100);

                    return boolResult;
                }
            );
        }

        public static async Task<object> Execute(this IChromeSession chromeSession, string expression)
        {
            var result = (await chromeSession.SendAsync(new EvaluateCommand
            {
                Expression = expression,
                ObjectGroup = "console",
                IncludeCommandLineAPI = true,
                ReturnByValue = true,
            })).Result;

            result.ExceptionDetails?.Throw();

            return result.Result.Value;
        }
    }
}