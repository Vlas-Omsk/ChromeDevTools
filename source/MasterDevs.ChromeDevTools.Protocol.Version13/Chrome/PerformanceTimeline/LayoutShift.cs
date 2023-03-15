using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.PerformanceTimeline
{
	/// <summary>
	/// See https://wicg.github.io/layout-instability/#sec-layout-shift and layout_shift.idl
	/// </summary>
	[SupportedBy("Chrome")]
	public class LayoutShift
	{
		/// <summary>
		/// Score increment produced by this event.
		/// </summary>
		public double Value { get; set; }
		/// <summary>
		/// HadRecentInput
		/// </summary>
		public bool HadRecentInput { get; set; }
		/// <summary>
		/// LastInputTime
		/// </summary>
		public double LastInputTime { get; set; }
		/// <summary>
		/// Sources
		/// </summary>
		public LayoutShiftAttribution[] Sources { get; set; }
	}
}
