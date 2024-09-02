using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Network
{
	/// <summary>
	/// Fired when WebSocket frame error occurs.
	/// </summary>
	[EventName(ProtocolName.Network.WebSocketFrameError)]
	[SupportedBy("IOS")]
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
		/// WebSocket frame error message.
		/// </summary>
		public string ErrorMessage { get; set; }
	}
}
