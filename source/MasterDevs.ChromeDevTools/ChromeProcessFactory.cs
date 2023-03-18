namespace MasterDevs.ChromeDevTools
{
    public sealed class ChromeProcessFactory : IChromeProcessFactory
    {
        private readonly IChromeSessionFactory _sessionFactory;

        public ChromeProcessFactory(IChromeSessionFactory sessionFactory)
        {
            _sessionFactory = sessionFactory;
        }

        public IChromeProcess Create(string remoteDebuggingUri)
        {
            return new ChromeProcess(remoteDebuggingUri, _sessionFactory);
        }
    }
}
