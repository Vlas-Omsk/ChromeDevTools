using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Overlay
{
	/// <summary>
	/// Highlights owner element of the frame with given id.
	/// Deprecated: Doesn't work reliablity and cannot be fixed due to process
	/// separatation (the owner node might be in a different process). Determine
	/// the owner node in the client and use highlightNode.
	/// </summary>
	[Obsolete]

	[SupportedBy("Chrome")]
	public class HighlightFrameCommandParams: ICommandParams<HighlightFrameCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Overlay.HighlightFrame;
		/// <summary>
		/// Identifier of the frame to highlight.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// The content box highlight fill color (default: transparent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA ContentColor { get; set; }
		/// <summary>
		/// The content box highlight outline color (default: transparent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA ContentOutlineColor { get; set; }
	}
}
