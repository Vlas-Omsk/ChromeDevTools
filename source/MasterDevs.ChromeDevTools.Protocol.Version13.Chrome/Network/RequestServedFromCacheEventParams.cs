using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Fired if request ended up loading from cache.
	/// </summary>
	[EventName(ProtocolName.Network.RequestServedFromCache)]
	[SupportedBy("Chrome")]
	public class RequestServedFromCacheEventParams : IEventParams
	{
		/// <summary>
		/// Request identifier.
		/// </summary>
		public string RequestId { get; set; }
	}
}
