using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOM
{
	/// <summary>
	/// Highlights all DOM nodes that match a given selector. A string containing a CSS selector must be specified.
	/// </summary>

	[SupportedBy("IOS")]
	public class HighlightSelectorCommandParams: ICommandParams<HighlightSelectorCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.HighlightSelector;
		/// <summary>
		/// A descriptor for the highlight appearance.
		/// </summary>
		public HighlightConfig HighlightConfig { get; set; }
		/// <summary>
		/// A CSS selector for finding matching nodes to highlight.
		/// </summary>
		public string SelectorString { get; set; }
		/// <summary>
		/// Identifier of the frame which will be searched using the selector.  If not provided, the main frame will be used.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string FrameId { get; set; }
	}
}
