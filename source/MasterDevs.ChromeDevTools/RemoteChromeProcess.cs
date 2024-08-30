using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools
{
    internal sealed class RemoteChromeProcess : IChromeProcess
    {
        private readonly Uri _remoteDebuggingUri;
        private readonly RemoteChromeSessionFactory _sessionFactory;
        private readonly HttpClient _httpClient;

        internal RemoteChromeProcess(Uri remoteDebuggingUri, RemoteChromeSessionFactory sessionFactory)
        {
            _remoteDebuggingUri = remoteDebuggingUri;
            _sessionFactory = sessionFactory;
            _httpClient = new HttpClient
            {
                BaseAddress = _remoteDebuggingUri
            };
        }

        public async Task<IEnumerable<IChromeSessionConnector>> GetSessionsAsync()
        {
            var json = await _httpClient.GetStringAsync("/json").ConfigureAwait(false);

            var infos = JsonConvert.DeserializeObject<SessionInfo[]>(json) ??
                throw new Exception("Response was empty");

            return infos.Select(x => new RemoteChromeSessionConnector(x, _sessionFactory));
        }

        public async Task<IChromeSessionConnector> StartNewSessionAsync()
        {
            var response = await _httpClient.SendAsync(
                new HttpRequestMessage(HttpMethod.Put, "/json/new")
            ).ConfigureAwait(false);

            var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            var info = JsonConvert.DeserializeObject<SessionInfo>(json) ??
                throw new Exception("Response was empty");

            return new RemoteChromeSessionConnector(info, _sessionFactory);
        }

        public void Dispose()
        {
            _httpClient.Dispose();
        }
    }
}