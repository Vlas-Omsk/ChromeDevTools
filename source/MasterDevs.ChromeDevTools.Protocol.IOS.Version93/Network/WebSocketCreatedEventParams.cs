using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Network
{
	/// <summary>
	/// Fired upon WebSocket creation.
	/// </summary>
	[EventName(ProtocolName.Network.WebSocketCreated)]
	[SupportedBy("IOS")]
	public class WebSocketCreatedEventParams : IEventParams
	{
		/// <summary>
		/// Request identifier.
		/// </summary>
		public string RequestId { get; set; }
		/// <summary>
		/// WebSocket request URL.
		/// </summary>
		public string Url { get; set; }
	}
}
