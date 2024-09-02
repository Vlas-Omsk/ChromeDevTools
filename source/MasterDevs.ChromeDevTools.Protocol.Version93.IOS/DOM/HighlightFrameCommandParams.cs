using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOM
{
	/// <summary>
	/// Highlights owner element of the frame with given id.
	/// </summary>

	[SupportedBy("IOS")]
	public class HighlightFrameCommandParams: ICommandParams<HighlightFrameCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.HighlightFrame;
		/// <summary>
		/// Identifier of the frame to highlight.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// The content box highlight fill color (default: transparent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RGBAColor ContentColor { get; set; }
		/// <summary>
		/// The content box highlight outline color (default: transparent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RGBAColor ContentOutlineColor { get; set; }
	}
}
