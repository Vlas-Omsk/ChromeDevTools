using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Network
{
	/// <summary>
	/// WebSocket request data.
	/// </summary>
	[SupportedBy("Chrome")]
	public class WebSocketRequest
	{
		/// <summary>
		/// HTTP request headers.
		/// </summary>
		public Dictionary<string, string> Headers { get; set; }
	}
}
