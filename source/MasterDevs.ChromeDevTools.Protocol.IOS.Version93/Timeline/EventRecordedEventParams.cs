using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Timeline
{
	/// <summary>
	/// Fired for every instrumentation event while timeline is started.
	/// </summary>
	[EventName(ProtocolName.Timeline.EventRecorded)]
	[SupportedBy("IOS")]
	public class EventRecordedEventParams : IEventParams
	{
		/// <summary>
		/// Timeline event record data.
		/// </summary>
		public TimelineEvent Record { get; set; }
	}
}
