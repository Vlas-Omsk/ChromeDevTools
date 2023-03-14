namespace MasterDevs.ChromeDevTools
{
    public class ChromeProcessFactory : IChromeProcessFactory
    {
        private readonly IChromeSessionFactory _sessionFactory;
        private readonly IDirectoryCleaner _directoryCleaner;
        private readonly string _chromePath;

        public ChromeProcessFactory(IChromeSessionFactory sessionFactory, IDirectoryCleaner directoryCleaner, string chromePath)
        {
            _sessionFactory = sessionFactory;
            _directoryCleaner = directoryCleaner;
            _chromePath = chromePath;
        }

        public IChromeProcess Create(ChromeProcessParameters parameters)
        {
            return new LocalChromeProcess(
                _directoryCleaner,
                _chromePath,
                parameters,
                _sessionFactory
            );
        }
    }
}