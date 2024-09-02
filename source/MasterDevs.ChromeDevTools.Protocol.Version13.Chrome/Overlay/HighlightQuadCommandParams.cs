using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Overlay
{
	/// <summary>
	/// Highlights given quad. Coordinates are absolute with respect to the main frame viewport.
	/// </summary>

	[SupportedBy("Chrome")]
	public class HighlightQuadCommandParams: ICommandParams<HighlightQuadCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Overlay.HighlightQuad;
		/// <summary>
		/// Quad to highlight
		/// </summary>
		public double[] Quad { get; set; }
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
