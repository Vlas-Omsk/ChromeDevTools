using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Network
{
	/// <summary>
	/// WebSocket request data.
	/// </summary>
	[SupportedBy("IOS")]
	public class WebSocketRequest
	{
		/// <summary>
		/// HTTP response headers.
		/// </summary>
		public Dictionary<string, string> Headers { get; set; }
	}
}
