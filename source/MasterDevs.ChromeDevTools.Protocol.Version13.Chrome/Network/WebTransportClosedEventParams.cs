using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Fired when WebTransport is disposed.
	/// </summary>
	[EventName(ProtocolName.Network.WebTransportClosed)]
	[SupportedBy("Chrome")]
	public class WebTransportClosedEventParams : IEventParams
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
