using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Network
{
	/// <summary>
	/// WebSocket response data.
	/// </summary>
	[SupportedBy("IOS")]
	public class WebSocketResponse
	{
		/// <summary>
		/// HTTP response status code.
		/// </summary>
		public double Status { get; set; }
		/// <summary>
		/// HTTP response status text.
		/// </summary>
		public string StatusText { get; set; }
		/// <summary>
		/// HTTP response headers.
		/// </summary>
		public Dictionary<string, string> Headers { get; set; }
	}
}
