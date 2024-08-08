using System;
using System.Threading;
using System.Threading.Tasks;

namespace MasterDevs.ChromeDevTools
{
    public interface IProtocolCommand<T>
    {

    }

    public interface IChromeSession
    {
        Task Close(CancellationToken cancellationToken);
        Task WaitWhile(string expression, TimeSpan? timeout = null, CancellationToken cancellationToken = default);
        Task<object> Execute(string expression, CancellationToken cancellationToken);
        Task Naviagte(string url, CancellationToken cancellationToken);
        Task<CommandResponse<T>> SendAsync<T>(IProtocolCommand<T> parameter, CancellationToken cancellationToken);
        Task<ICommandResponse> SendAsync<T>(CancellationToken cancellationToken);
        void Subscribe<T>(Func<T, Task> handler) where T : class;
    }
}