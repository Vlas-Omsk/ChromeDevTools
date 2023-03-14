using System;
using System.Threading.Tasks;

namespace MasterDevs.ChromeDevTools
{
    public interface IChromeProcess : IDisposable
    {
        Uri RemoteDebuggingUri { get; }

        Task<ChromeSessionInfo[]> GetSessionsRaw();
        Task<ChromeSessionInfo> StartNewSessionRaw();
        Task<IChromeSession> StartNewSession();
    }
}