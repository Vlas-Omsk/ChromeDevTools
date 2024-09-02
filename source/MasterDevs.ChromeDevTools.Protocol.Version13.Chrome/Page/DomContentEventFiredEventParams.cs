using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	[EventName(ProtocolName.Page.DomContentEventFired)]
	[SupportedBy("Chrome")]
	public class DomContentEventFiredEventParams : IEventParams
	{
		/// <summary>
		/// Timestamp
		/// </summary>
		public double Timestamp { get; set; }
	}
}
