using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	[Event(ProtocolName.Page.LoadEventFired)]
	[SupportedBy("iOS")]
	public class LoadEventFiredEvent
	{
		/// <summary>
		/// Timestamp
		/// </summary>
		public double Timestamp { get; set; }
	}
}
