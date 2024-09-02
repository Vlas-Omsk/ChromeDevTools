using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOM
{
	/// <summary>
	/// Highlights given quad. Coordinates are absolute with respect to the main frame viewport.
	/// </summary>

	[SupportedBy("IOS")]
	public class HighlightQuadCommandParams: ICommandParams<HighlightQuadCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.HighlightQuad;
		/// <summary>
		/// Quad to highlight
		/// </summary>
		public double[] Quad { get; set; }
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
