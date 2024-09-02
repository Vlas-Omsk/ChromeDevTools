using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Fired when WebTransport handshake is finished.
	/// </summary>
	[EventName(ProtocolName.Network.WebTransportConnectionEstablished)]
	[SupportedBy("Chrome")]
	public class WebTransportConnectionEstablishedEventParams : IEventParams
	{
		/// <summary>
		/// WebTransport identifier.
		/// </summary>
		public string TransportId { get; set; }
		/// <summary>
		/// Timestamp.
		/// </summary>
		public double Timestamp { get; set; }
	}
}
