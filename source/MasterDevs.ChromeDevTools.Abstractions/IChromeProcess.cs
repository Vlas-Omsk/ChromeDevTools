using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MasterDevs.ChromeDevTools
{
    public interface IChromeProcess : IDisposable
    {
        Task<IEnumerable<IChromeSessionConnector>> GetSessionsAsync();
        Task<IChromeSessionConnector> StartNewSessionAsync();
    }
}