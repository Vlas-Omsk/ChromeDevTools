using MasterDevs.ChromeDevTools.Protocol;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MasterDevs.ChromeDevTools
{
    public interface IChromeSession
    {
        Task<CommandResponse<T>> SendAsync<T>(ICommandParams<T> parameter, string? sessionId, CancellationToken cancellationToken) where T : ICommandResult;
        void Subscribe<T>(Func<Event<T>, Task> handler) where T : IEventParams;
    }
}