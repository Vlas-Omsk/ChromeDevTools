using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Page
{
	[EventName(ProtocolName.Page.LoadEventFired)]
	[SupportedBy("IOS")]
	public class LoadEventFiredEventParams : IEventParams
	{
		/// <summary>
		/// Timestamp
		/// </summary>
		public double Timestamp { get; set; }
	}
}
