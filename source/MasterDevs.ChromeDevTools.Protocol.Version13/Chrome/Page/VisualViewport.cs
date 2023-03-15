using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Visual viewport position, dimensions, and scale.
	/// </summary>
	[SupportedBy("Chrome")]
	public class VisualViewport
	{
		/// <summary>
		/// Horizontal offset relative to the layout viewport (CSS pixels).
		/// </summary>
		public double OffsetX { get; set; }
		/// <summary>
		/// Vertical offset relative to the layout viewport (CSS pixels).
		/// </summary>
		public double OffsetY { get; set; }
		/// <summary>
		/// Horizontal offset relative to the document (CSS pixels).
		/// </summary>
		public double PageX { get; set; }
		/// <summary>
		/// Vertical offset relative to the document (CSS pixels).
		/// </summary>
		public double PageY { get; set; }
		/// <summary>
		/// Width (CSS pixels), excludes scrollbar if present.
		/// </summary>
		public double ClientWidth { get; set; }
		/// <summary>
		/// Height (CSS pixels), excludes scrollbar if present.
		/// </summary>
		public double ClientHeight { get; set; }
		/// <summary>
		/// Scale relative to the ideal viewport (size at width=device-width).
		/// </summary>
		public double Scale { get; set; }
		/// <summary>
		/// Page zoom factor (CSS to device independent pixels ratio).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Zoom { get; set; }
	}
}
