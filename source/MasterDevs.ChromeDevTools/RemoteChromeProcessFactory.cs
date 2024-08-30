using System;

namespace MasterDevs.ChromeDevTools
{
    public sealed class RemoteChromeProcessFactory
    {
        private readonly RemoteChromeSessionFactory _sessionFactory;

        public RemoteChromeProcessFactory(IProtocolTypeMap protocolTypeMap)
        {
            _sessionFactory = new RemoteChromeSessionFactory(protocolTypeMap);
        }

        public IChromeProcess Create(Uri remoteDebuggingUri)
        {
            return new RemoteChromeProcess(remoteDebuggingUri, _sessionFactory);
        }
    }
}
