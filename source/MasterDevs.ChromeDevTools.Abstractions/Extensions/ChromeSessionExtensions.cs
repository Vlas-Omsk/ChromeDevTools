using System.Threading;
using System.Threading.Tasks;

namespace MasterDevs.ChromeDevTools
{
    public static class ChromeSessionExtensions
    {
        public static Task<CommandResponse<T>> SendAsync<T>(this IChromeSession session, IProtocolCommand<T> parameter, CancellationToken cancellationToken)
        {
            return session.SendAsync(parameter, cancellationToken);
        }

        public static Task<ICommandResponse> SendAsync<T>(this IChromeSession session, CancellationToken cancellationToken)
        {
            return session.SendAsync<T>(cancellationToken);
        }
    }
}
