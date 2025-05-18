using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Overlay
{
	/// <summary>
	/// Highlights given rectangle. Coordinates are absolute with respect to the main frame viewport.
	/// </summary>

	[SupportedBy("Chrome")]
	public class HighlightRectCommand: ICommand<HighlightRectCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Overlay.HighlightRect;
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
		public DOM.RGBA Color { get; set; }
		/// <summary>
		/// The highlight outline color (default: transparent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA OutlineColor { get; set; }
	}
}
