using MasterDevs.ChromeDevTools.Protocol;
using System.Threading;
using System.Threading.Tasks;

namespace MasterDevs.ChromeDevTools
{
    public static class ChromeSessionExtensions
    {
        public static Task<CommandResponse<T>> SendAsync<T>(this IChromeSession self, ICommandParams<T> parameter, CancellationToken cancellationToken)
            where T : ICommandResult
        {
            return self.SendAsync(parameter, sessionId: null, cancellationToken);
        }
    }
}
