namespace MasterDevs.ChromeDevTools
{
    public sealed class ChromeProcessParameters
    {
        public ChromeProcessParameters(int port, string userDataDirectory, string parameters)
        {
            Port = port;
            UserDataDirectory = userDataDirectory;
            Parameters = parameters;
        }

        public int Port { get; }
        public string UserDataDirectory { get; }
        public string Parameters { get; }
    }
}
