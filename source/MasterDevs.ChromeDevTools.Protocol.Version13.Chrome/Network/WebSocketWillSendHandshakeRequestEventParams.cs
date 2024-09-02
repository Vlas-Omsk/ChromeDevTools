using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Fired when WebSocket is about to initiate handshake.
	/// </summary>
	[EventName(ProtocolName.Network.WebSocketWillSendHandshakeRequest)]
	[SupportedBy("Chrome")]
	public class WebSocketWillSendHandshakeRequestEventParams : IEventParams
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
		/// UTC Timestamp.
		/// </summary>
		public double WallTime { get; set; }
		/// <summary>
		/// WebSocket request data.
		/// </summary>
		public WebSocketRequest Request { get; set; }
	}
}
