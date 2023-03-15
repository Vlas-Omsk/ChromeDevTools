using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.OverlayTypes
{
	[SupportedBy("iOS")]
	public class ShapeOutsideData
	{
		/// <summary>
		/// Bounds for the shape-outside paths.
		/// </summary>
		public Point[] Bounds { get; set; }
		/// <summary>
		/// Path for the element's shape.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public object[] Shape { get; set; }
		/// <summary>
		/// Path for the element's margin shape.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public object[] MarginShape { get; set; }
	}
}
