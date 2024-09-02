using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Fired when WebSocket message error occurs.
	/// </summary>
	[EventName(ProtocolName.Network.WebSocketFrameError)]
	[SupportedBy("Chrome")]
	public class WebSocketFrameErrorEventParams : IEventParams
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
		/// WebSocket error message.
		/// </summary>
		public string ErrorMessage { get; set; }
	}
}
