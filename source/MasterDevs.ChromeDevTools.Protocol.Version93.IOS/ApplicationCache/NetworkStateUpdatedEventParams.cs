using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.ApplicationCache
{
	[EventName(ProtocolName.ApplicationCache.NetworkStateUpdated)]
	[SupportedBy("IOS")]
	public class NetworkStateUpdatedEventParams : IEventParams
	{
		/// <summary>
		/// IsNowOnline
		/// </summary>
		public bool IsNowOnline { get; set; }
	}
}
