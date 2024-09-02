using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOM
{
	/// <summary>
	/// Highlights given rectangle. Coordinates are absolute with respect to the main frame viewport.
	/// </summary>

	[SupportedBy("IOS")]
	public class HighlightRectCommandParams: ICommandParams<HighlightRectCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.HighlightRect;
		/// <summary>
		/// X coordinate
		/// </summary>
		public long X { get; set; }
		/// <summary>
		/// Y coordinate
		/// </summary>
		public long Y { get; set; }
		/// <summary>
		/// Rectangle width
		/// </summary>
		public long Width { get; set; }
		/// <summary>
		/// Rectangle height
		/// </summary>
		public long Height { get; set; }
		/// <summary>
		/// The highlight fill color (default: transparent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RGBAColor Color { get; set; }
		/// <summary>
		/// The highlight outline color (default: transparent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RGBAColor OutlineColor { get; set; }
		/// <summary>
		/// Indicates whether the provided parameters are in page coordinates or in viewport coordinates (the default).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? UsePageCoordinates { get; set; }
	}
}
