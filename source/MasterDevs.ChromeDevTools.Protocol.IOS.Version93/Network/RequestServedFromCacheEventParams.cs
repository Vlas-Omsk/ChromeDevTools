using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Network
{
	/// <summary>
	/// Fired if request ended up loading from cache.
	/// </summary>
	[EventName(ProtocolName.Network.RequestServedFromCache)]
	[SupportedBy("IOS")]
	public class RequestServedFromCacheEventParams : IEventParams
	{
		/// <summary>
		/// Request identifier.
		/// </summary>
		public string RequestId { get; set; }
	}
}
