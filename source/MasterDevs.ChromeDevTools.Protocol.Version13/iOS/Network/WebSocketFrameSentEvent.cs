using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Network
{
	/// <summary>
	/// Fired when WebSocket frame is sent.
	/// </summary>
	[Event(ProtocolName.Network.WebSocketFrameSent)]
	[SupportedBy("iOS")]
	public class WebSocketFrameSentEvent
	{
		/// <summary>
		/// Request identifier.
		/// </summary>
		public string RequestId { get; set; }
		/// <summary>
		/// Timestamp.
		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// WebSocket response data.
		/// </summary>
		public WebSocketFrame Response { get; set; }
	}
}
