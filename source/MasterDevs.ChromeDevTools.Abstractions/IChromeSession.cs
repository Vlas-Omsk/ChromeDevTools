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
        Task Close();
        void WaitWhile(string expression, TimeSpan? timeout = null);
        Task<object> Execute(string expression);
        Task Naviagte(string url);
        Task<CommandResponse<T>> SendAsync<T>(IProtocolCommand<T> parameter, CancellationToken cancellationToken);
        Task<ICommandResponse> SendAsync<T>(CancellationToken cancellationToken);
        void Subscribe<T>(Action<T> handler) where T : class;
    }
}