using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Network
{
	/// <summary>
	/// Fired when WebSocket handshake response becomes available.
	/// </summary>
	[EventName(ProtocolName.Network.WebSocketHandshakeResponseReceived)]
	[SupportedBy("IOS")]
	public class WebSocketHandshakeResponseReceivedEventParams : IEventParams
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
		public WebSocketResponse Response { get; set; }
	}
}