using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.OverlayTypes
{
	/// <summary>
	/// Data required to highlight multiple quads.
	/// </summary>
	[SupportedBy("IOS")]
	public class FragmentHighlightData
	{
		/// <summary>
		/// Quads for which the highlight should be applied.
		/// </summary>
		public Point[][] Quads { get; set; }
		/// <summary>
		/// ContentColor
		/// </summary>
		public string ContentColor { get; set; }
		/// <summary>
		/// ContentOutlineColor
		/// </summary>
		public string ContentOutlineColor { get; set; }
		/// <summary>
		/// PaddingColor
		/// </summary>
		public string PaddingColor { get; set; }
		/// <summary>
		/// BorderColor
		/// </summary>
		public string BorderColor { get; set; }
		/// <summary>
		/// MarginColor
		/// </summary>
		public string MarginColor { get; set; }
		/// <summary>
		/// RegionClippingArea
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Point[] RegionClippingArea { get; set; }
	}
}
