using System.Threading.Tasks;

namespace MasterDevs.ChromeDevTools
{
    public sealed class RemoteChromeSessionConnector : IChromeSessionConnector
    {
        private readonly SessionInfo _info;
        private readonly RemoteChromeSessionFactory _sessionFactory;

        internal RemoteChromeSessionConnector(SessionInfo info, RemoteChromeSessionFactory sessionFactory)
        {
            _info = info;
            _sessionFactory = sessionFactory;
        }

        public string Id => _info.Id;
        public string Title => _info.Title;
        public string Description => _info.Description;
        public string Type => _info.Type;
        public string Url => _info.Url;

        public Task<IChromeSession> ConnectAsync()
        {
            return Task.FromResult(
                _sessionFactory.Create(_info.WebSocketDebuggerUrl, _info.Id)
            );
        }
    }
}
