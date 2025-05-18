using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.ApplicationCache
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
