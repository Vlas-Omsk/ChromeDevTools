namespace MasterDevs.ChromeDevTools.Local
{
    public class LocalChromeProcessFactory : ILocalChromeProcessFactory
    {
        private readonly IChromeSessionFactory _sessionFactory;
        private readonly string _chromePath;

        public LocalChromeProcessFactory(IChromeSessionFactory sessionFactory, string chromePath)
        {
            _sessionFactory = sessionFactory;
            _chromePath = chromePath;
        }

        public ILocalChromeProcess Create(ChromeProcessParameters parameters)
        {
            return Create(parameters, new StubbornDirectoryCleaner());
        }

        public ILocalChromeProcess Create(ChromeProcessParameters parameters, IDirectoryCleaner directoryCleaner)
        {
            return new LocalChromeProcess(
                directoryCleaner,
                _chromePath,
                parameters,
                _sessionFactory
            );
        }

        IChromeProcess IChromeProcessFactory.Create(ChromeProcessParameters parameters)
        {
            return Create(parameters);
        }
    }
}