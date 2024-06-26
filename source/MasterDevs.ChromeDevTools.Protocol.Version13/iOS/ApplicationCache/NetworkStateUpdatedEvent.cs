using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.ApplicationCache
{
	[Event(ProtocolName.ApplicationCache.NetworkStateUpdated)]
	[SupportedBy("iOS")]
	public class NetworkStateUpdatedEvent
	{
		/// <summary>
		/// IsNowOnline
		/// </summary>
		public bool IsNowOnline { get; set; }
	}
}
