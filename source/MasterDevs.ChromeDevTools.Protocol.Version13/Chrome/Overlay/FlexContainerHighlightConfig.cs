using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Configuration data for the highlighting of Flex container elements.
	/// </summary>
	[SupportedBy("Chrome")]
	public class FlexContainerHighlightConfig
	{
		/// <summary>
		/// The style of the container border
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public LineStyle ContainerBorder { get; set; }
		/// <summary>
		/// The style of the separator between lines
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public LineStyle LineSeparator { get; set; }
		/// <summary>
		/// The style of the separator between items
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public LineStyle ItemSeparator { get; set; }
		/// <summary>
		/// Style of content-distribution space on the main axis (justify-content).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public BoxStyle MainDistributedSpace { get; set; }
		/// <summary>
		/// Style of content-distribution space on the cross axis (align-content).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public BoxStyle CrossDistributedSpace { get; set; }
		/// <summary>
		/// Style of empty space caused by row gaps (gap/row-gap).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public BoxStyle RowGapSpace { get; set; }
		/// <summary>
		/// Style of empty space caused by columns gaps (gap/column-gap).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public BoxStyle ColumnGapSpace { get; set; }
		/// <summary>
		/// Style of the self-alignment line (align-items).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public LineStyle CrossAlignment { get; set; }
	}
}
