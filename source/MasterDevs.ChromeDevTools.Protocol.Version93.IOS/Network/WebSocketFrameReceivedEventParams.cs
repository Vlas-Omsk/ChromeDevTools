using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Network
{
	/// <summary>
	/// Fired when WebSocket frame is received.
	/// </summary>
	[EventName(ProtocolName.Network.WebSocketFrameReceived)]
	[SupportedBy("IOS")]
	public class WebSocketFrameReceivedEventParams : IEventParams
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
