using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Network
{
	/// <summary>
	/// Fired when WebSocket message is sent.
	/// </summary>
	[EventName(ProtocolName.Network.WebSocketFrameSent)]
	[SupportedBy("Chrome")]
	public class WebSocketFrameSentEventParams : IEventParams
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
