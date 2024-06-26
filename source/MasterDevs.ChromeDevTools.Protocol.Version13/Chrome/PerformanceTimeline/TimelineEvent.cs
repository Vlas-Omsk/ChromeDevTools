using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.PerformanceTimeline
{
	[SupportedBy("Chrome")]
	public class TimelineEvent
	{
		/// <summary>
		/// Identifies the frame that this event is related to. Empty for non-frame targets.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// The event type, as specified in https://w3c.github.io/performance-timeline/#dom-performanceentry-entrytype
		/// This determines which of the optional "details" fiedls is present.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Name may be empty depending on the type.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Time in seconds since Epoch, monotonically increasing within document lifetime.
		/// </summary>
		public double Time { get; set; }
		/// <summary>
		/// Event duration, if applicable.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Duration { get; set; }
		/// <summary>
		/// LcpDetails
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public LargestContentfulPaint LcpDetails { get; set; }
		/// <summary>
		/// LayoutShiftDetails
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public LayoutShift LayoutShiftDetails { get; set; }
	}
}
