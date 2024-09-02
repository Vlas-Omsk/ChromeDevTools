using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOM
{
	/// <summary>
	/// Configuration data for the highlighting of page elements.
	/// </summary>
	[SupportedBy("IOS")]
	public class HighlightConfig
	{
		/// <summary>
		/// Whether the node info tooltip should be shown (default: false).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ShowInfo { get; set; }
		/// <summary>
		/// The content box highlight fill color (default: transparent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RGBAColor ContentColor { get; set; }
		/// <summary>
		/// The padding highlight fill color (default: transparent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RGBAColor PaddingColor { get; set; }
		/// <summary>
		/// The border highlight fill color (default: transparent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RGBAColor BorderColor { get; set; }
		/// <summary>
		/// The margin highlight fill color (default: transparent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RGBAColor MarginColor { get; set; }
	}
}
