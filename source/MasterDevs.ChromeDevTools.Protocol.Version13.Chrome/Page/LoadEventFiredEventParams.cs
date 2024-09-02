using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	[EventName(ProtocolName.Page.LoadEventFired)]
	[SupportedBy("Chrome")]
	public class LoadEventFiredEventParams : IEventParams
	{
		/// <summary>
		/// Timestamp
		/// </summary>
		public double Timestamp { get; set; }
	}
}
