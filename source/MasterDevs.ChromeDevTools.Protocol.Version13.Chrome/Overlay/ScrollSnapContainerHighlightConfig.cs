using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Overlay
{
	[SupportedBy("Chrome")]
	public class ScrollSnapContainerHighlightConfig
	{
		/// <summary>
		/// The style of the snapport border (default: transparent)
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public LineStyle SnapportBorder { get; set; }
		/// <summary>
		/// The style of the snap area border (default: transparent)
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public LineStyle SnapAreaBorder { get; set; }
		/// <summary>
		/// The margin highlight fill color (default: transparent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA ScrollMarginColor { get; set; }
		/// <summary>
		/// The padding highlight fill color (default: transparent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA ScrollPaddingColor { get; set; }
	}
}
