using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Fired when a signed exchange was received over the network
	/// </summary>
	[EventName(ProtocolName.Network.SignedExchangeReceived)]
	[SupportedBy("Chrome")]
	public class SignedExchangeReceivedEventParams : IEventParams
	{
		/// <summary>
		/// Request identifier.
		/// </summary>
		public string RequestId { get; set; }
		/// <summary>
		/// Information about the signed exchange response.
		/// </summary>
		public SignedExchangeInfo Info { get; set; }
	}
}
