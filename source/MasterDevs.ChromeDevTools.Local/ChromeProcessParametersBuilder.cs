using System;
using System.Collections.Generic;
using System.IO;
using System.Net.NetworkInformation;
using System.Text;

namespace MasterDevs.ChromeDevTools.Local
{
    public sealed class ChromeProcessParametersBuilder
    {
        private static readonly string[] _reservedParameters = { "remote-debugging-port", "user-data-dir" };
        private static int _randomPortCounter = 9222;
        private readonly int _port;
        private readonly string _userDataDirectory;
        private readonly Dictionary<string, object?> _parameters = new Dictionary<string, object?>();

        public ChromeProcessParametersBuilder() : this(GetRandomPort())
        {
        }

        public ChromeProcessParametersBuilder(int port) : this(port, GetRandomDirectory())
        {
        }

        public ChromeProcessParametersBuilder(int port, string userDataDirectory)
        {
            _port = port;
            _userDataDirectory = userDataDirectory;

            _parameters["remote-debugging-port"] = port;
            _parameters["user-data-dir"] = userDataDirectory;
            _parameters["no-first-run"] = null;
            _parameters["remote-allow-origins"] = "*";
        }

        public ChromeProcessParametersBuilder SetParameter(string name)
        {
            return SetParameter(name, null);
        }

        public ChromeProcessParametersBuilder SetParameter(string name, object? value)
        {
            if (Array.Exists(_reservedParameters, x => x == name))
                throw new InvalidOperationException("Cannot set reserved parameter");

            _parameters[name] = value;

            return this;
        }

        public ChromeProcessParametersBuilder SetHeadless()
        {
            return SetParameter("headless")
                .SetParameter("disable-gpu");
        }

        public ChromeProcessParametersBuilder SetIncognito()
        {
            return SetParameter("bwsi");
        }

        public ChromeProcessParametersBuilder SetHttpProxy(string host, int port)
        {
            return SetParameter("proxy-server", $"http://{host}:{port}");
        }

        public ChromeProcessParameters Build()
        {
            return new ChromeProcessParameters(
                _port,
                _userDataDirectory,
                BuildArguments()
            );
        }

        private string BuildArguments()
        {
            var result = new StringBuilder();
            var i = 0;

            foreach (var parameter in _parameters)
            {
                var parameterType = parameter.Value?.GetType();

                if (parameterType == typeof(string))
                    result.Append($"--{parameter.Key}=\"{parameter.Value}\"");
                else if (parameterType == typeof(int))
                    result.Append($"--{parameter.Key}={parameter.Value}");
                else if (parameterType == null)
                    result.Append($"--{parameter.Key}");
                else
                    throw new Exception("Invalid parameter type");

                i++;

                if (i != _parameters.Count)
                    result.Append(' ');
            }

            return result.ToString();
        }

        private static string GetRandomDirectory()
        {
            var path = Path.GetRandomFileName();
            var directoryInfo = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), path));

            return directoryInfo.FullName;
        }

        private static int GetRandomPort()
        {
            var port = _randomPortCounter++;

            while (!IsTcpPortAvailable(port))
                port = _randomPortCounter++;

            return port;
        }

        private static bool IsTcpPortAvailable(int port)
        {
            try
            {
                var ipGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
                var tcpListeners = ipGlobalProperties.GetActiveTcpListeners();

                foreach (var tcpListener in tcpListeners)
                    if (tcpListener.Port == port)
                        return false;

                return true;
            }
            catch
            {
                return true;
            }
        }
    }
}
