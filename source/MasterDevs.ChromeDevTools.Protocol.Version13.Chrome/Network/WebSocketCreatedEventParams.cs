using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Fired upon WebSocket creation.
	/// </summary>
	[EventName(ProtocolName.Network.WebSocketCreated)]
	[SupportedBy("Chrome")]
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
		/// <summary>
		/// Request initiator.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Initiator Initiator { get; set; }
	}
}
