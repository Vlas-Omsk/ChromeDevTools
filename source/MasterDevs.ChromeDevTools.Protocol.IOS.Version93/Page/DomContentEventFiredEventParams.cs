using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Page
{
	[EventName(ProtocolName.Page.DomContentEventFired)]
	[SupportedBy("IOS")]
	public class DomContentEventFiredEventParams : IEventParams
	{
		/// <summary>
		/// Timestamp
		/// </summary>
		public double Timestamp { get; set; }
	}
}
