using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.PerformanceTimeline
{
	/// <summary>
	/// Sent when a performance timeline event is added. See reportPerformanceTimeline method.
	/// </summary>
	[EventName(ProtocolName.PerformanceTimeline.TimelineEventAdded)]
	[SupportedBy("Chrome")]
	public class TimelineEventAddedEventParams : IEventParams
	{
		/// <summary>
		/// Event
		/// </summary>
		public TimelineEvent Event { get; set; }
	}
}
