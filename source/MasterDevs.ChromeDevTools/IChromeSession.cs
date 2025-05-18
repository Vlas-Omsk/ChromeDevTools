using MasterDevs.ChromeDevTools.Protocol;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MasterDevs.ChromeDevTools
{
    public interface IChromeSession
    {
        Task<T> SendAsync<T>(ICommand<T> command, string? sessionId, CancellationToken cancellationToken) where T : ICommandResult;
        void Subscribe<T>(Func<IEvent<T>, Task> handler) where T : IEventParams;
    }
}