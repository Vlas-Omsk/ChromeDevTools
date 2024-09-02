using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Overlay
{
	/// <summary>
	/// Style information for drawing a box.
	/// </summary>
	[SupportedBy("Chrome")]
	public class BoxStyle
	{
		/// <summary>
		/// The background color for the box (default: transparent)
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA FillColor { get; set; }
		/// <summary>
		/// The hatching color for the box (default: transparent)
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA HatchColor { get; set; }
	}
}
