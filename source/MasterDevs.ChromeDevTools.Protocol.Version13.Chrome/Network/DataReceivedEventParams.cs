using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Fired when data chunk was received over the network.
	/// </summary>
	[EventName(ProtocolName.Network.DataReceived)]
	[SupportedBy("Chrome")]
	public class DataReceivedEventParams : IEventParams
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
		/// Data chunk length.
		/// </summary>
		public long DataLength { get; set; }
		/// <summary>
		/// Actual bytes received (might be less than dataLength for compressed encodings).
		/// </summary>
		public long EncodedDataLength { get; set; }
	}
}
