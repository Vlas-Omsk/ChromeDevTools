using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools
{
    public sealed class ChromeProcessParameters
    {
        public ChromeProcessParameters(int port, string userDataDirectory, string arguments)
        {
            Port = port;
            UserDataDirectory = userDataDirectory;
            Arguments = arguments;
        }

        public int Port { get; }
        public string UserDataDirectory { get; }
        public string Arguments { get; }
    }
}
