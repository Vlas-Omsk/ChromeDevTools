using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMSnapshot
{
	/// <summary>
	/// Table of details of an element in the DOM tree with a LayoutObject.
	/// </summary>
	[SupportedBy("Chrome")]
	public class LayoutTreeSnapshot
	{
		/// <summary>
		/// Index of the corresponding node in the `NodeTreeSnapshot` array returned by `captureSnapshot`.
		/// </summary>
		public long[] NodeIndex { get; set; }
		/// <summary>
		/// Array of indexes specifying computed style strings, filtered according to the `computedStyles` parameter passed to `captureSnapshot`.
		/// </summary>
		public long[][] Styles { get; set; }
		/// <summary>
		/// The absolute position bounding box.
		/// </summary>
		public double[][] Bounds { get; set; }
		/// <summary>
		/// Contents of the LayoutText, if any.
		/// </summary>
		public long[] Text { get; set; }
		/// <summary>
		/// Stacking context information.
		/// </summary>
		public RareBooleanData StackingContexts { get; set; }
		/// <summary>
		/// Global paint order index, which is determined by the stacking order of the nodes. Nodes
		/// that are painted together will have the same index. Only provided if includePaintOrder in
		/// captureSnapshot was true.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long[] PaintOrders { get; set; }
		/// <summary>
		/// The offset rect of nodes. Only available when includeDOMRects is set to true
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double[][] OffsetRects { get; set; }
		/// <summary>
		/// The scroll rect of nodes. Only available when includeDOMRects is set to true
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double[][] ScrollRects { get; set; }
		/// <summary>
		/// The client rect of nodes. Only available when includeDOMRects is set to true
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double[][] ClientRects { get; set; }
		/// <summary>
		/// The list of background colors that are blended with colors of overlapping elements.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long[] BlendedBackgroundColors { get; set; }
		/// <summary>
		/// The list of computed text opacities.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double[] TextColorOpacities { get; set; }
	}
}
