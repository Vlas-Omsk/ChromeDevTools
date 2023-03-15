using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Configuration data for the highlighting of Grid elements.
	/// </summary>
	[SupportedBy("Chrome")]
	public class GridHighlightConfig
	{
		/// <summary>
		/// Whether the extension lines from grid cells to the rulers should be shown (default: false).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ShowGridExtensionLines { get; set; }
		/// <summary>
		/// Show Positive line number labels (default: false).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ShowPositiveLineNumbers { get; set; }
		/// <summary>
		/// Show Negative line number labels (default: false).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ShowNegativeLineNumbers { get; set; }
		/// <summary>
		/// Show area name labels (default: false).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ShowAreaNames { get; set; }
		/// <summary>
		/// Show line name labels (default: false).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ShowLineNames { get; set; }
		/// <summary>
		/// Show track size labels (default: false).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ShowTrackSizes { get; set; }
		/// <summary>
		/// The grid container border highlight color (default: transparent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA GridBorderColor { get; set; }
		/// <summary>
		/// The cell border color (default: transparent). Deprecated, please use rowLineColor and columnLineColor instead.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA CellBorderColor { get; set; }
		/// <summary>
		/// The row line color (default: transparent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA RowLineColor { get; set; }
		/// <summary>
		/// The column line color (default: transparent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA ColumnLineColor { get; set; }
		/// <summary>
		/// Whether the grid border is dashed (default: false).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? GridBorderDash { get; set; }
		/// <summary>
		/// Whether the cell border is dashed (default: false). Deprecated, please us rowLineDash and columnLineDash instead.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? CellBorderDash { get; set; }
		/// <summary>
		/// Whether row lines are dashed (default: false).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? RowLineDash { get; set; }
		/// <summary>
		/// Whether column lines are dashed (default: false).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ColumnLineDash { get; set; }
		/// <summary>
		/// The row gap highlight fill color (default: transparent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA RowGapColor { get; set; }
		/// <summary>
		/// The row gap hatching fill color (default: transparent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA RowHatchColor { get; set; }
		/// <summary>
		/// The column gap highlight fill color (default: transparent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA ColumnGapColor { get; set; }
		/// <summary>
		/// The column gap hatching fill color (default: transparent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA ColumnHatchColor { get; set; }
		/// <summary>
		/// The named grid areas border color (Default: transparent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA AreaBorderColor { get; set; }
		/// <summary>
		/// The grid container background color (Default: transparent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA GridBackgroundColor { get; set; }
	}
}
