using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Tethering
{
	/// <summary>
	/// Informs that port was successfully bound and got a specified connection id.
	/// </summary>
	[EventName(ProtocolName.Tethering.Accepted)]
	[SupportedBy("Chrome")]
	public class AcceptedEventParams : IEventParams
	{
		/// <summary>
		/// Port number that was successfully bound.
		/// </summary>
		public long Port { get; set; }
		/// <summary>
		/// Connection id to be used.
		/// </summary>
		public string ConnectionId { get; set; }
	}
}
