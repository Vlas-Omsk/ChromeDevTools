using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.PerformanceTimeline
{
	[SupportedBy("Chrome")]
	public class LayoutShiftAttribution
	{
		/// <summary>
		/// PreviousRect
		/// </summary>
		public DOM.Rect PreviousRect { get; set; }
		/// <summary>
		/// CurrentRect
		/// </summary>
		public DOM.Rect CurrentRect { get; set; }
		/// <summary>
		/// NodeId
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? NodeId { get; set; }
	}
}
