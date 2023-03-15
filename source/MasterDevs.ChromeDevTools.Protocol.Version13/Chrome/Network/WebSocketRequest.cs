using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
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
