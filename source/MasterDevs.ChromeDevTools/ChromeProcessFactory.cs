namespace MasterDevs.ChromeDevTools
{
    public class ChromeProcessFactory : IChromeProcessFactory
    {
        private readonly IChromeSessionFactory _sessionFactory;
        private readonly string _chromePath;

        public ChromeProcessFactory(IChromeSessionFactory sessionFactory, string chromePath)
        {
            _sessionFactory = sessionFactory;
            _chromePath = chromePath;
        }

        public IChromeProcess Create(ChromeProcessParameters parameters)
        {
            return Create(parameters, new StubbornDirectoryCleaner());
        }

        public IChromeProcess Create(ChromeProcessParameters parameters, IDirectoryCleaner directoryCleaner)
        {
            return new LocalChromeProcess(
                directoryCleaner,
                _chromePath,
                parameters,
                _sessionFactory
            );
        }
    }
}