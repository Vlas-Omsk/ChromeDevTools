using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Fired upon WebTransport creation.
	/// </summary>
	[EventName(ProtocolName.Network.WebTransportCreated)]
	[SupportedBy("Chrome")]
	public class WebTransportCreatedEventParams : IEventParams
	{
		/// <summary>
		/// WebTransport identifier.
		/// </summary>
		public string TransportId { get; set; }
		/// <summary>
		/// WebTransport request URL.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Timestamp.
		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// Request initiator.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Initiator Initiator { get; set; }
	}
}
