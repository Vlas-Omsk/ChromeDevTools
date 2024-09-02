using System;

namespace MasterDevs.ChromeDevTools
{
    public sealed class RemoteChromeProcessFactory
    {
        private readonly RemoteChromeSessionFactory _sessionFactory;

        public RemoteChromeProcessFactory()
        {
            _sessionFactory = new RemoteChromeSessionFactory();
        }

        public IChromeProcess Create(Uri remoteDebuggingUri)
        {
            return new RemoteChromeProcess(remoteDebuggingUri, _sessionFactory);
        }
    }
}
