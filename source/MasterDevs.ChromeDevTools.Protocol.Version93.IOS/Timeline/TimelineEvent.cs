using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Timeline
{
	/// <summary>
	/// Timeline record contains information about the recorded activity.
	/// </summary>
	[SupportedBy("IOS")]
	public class TimelineEvent
	{
		/// <summary>
		/// Event type.
		/// </summary>
		public EventType Type { get; set; }
		/// <summary>
		/// Event data.
		/// </summary>
		public object Data { get; set; }
		/// <summary>
		/// Nested records.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public TimelineEvent[] Children { get; set; }
	}
}
