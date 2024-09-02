using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Overlay
{
	/// <summary>
	/// Highlights the source order of the children of the DOM node with given id or with the given
	/// JavaScript object wrapper. Either nodeId or objectId must be specified.
	/// </summary>

	[SupportedBy("Chrome")]
	public class HighlightSourceOrderCommandParams: ICommandParams<HighlightSourceOrderCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Overlay.HighlightSourceOrder;
		/// <summary>
		/// A descriptor for the appearance of the overlay drawing.
		/// </summary>
		public SourceOrderConfig SourceOrderConfig { get; set; }
		/// <summary>
		/// Identifier of the node to highlight.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? NodeId { get; set; }
		/// <summary>
		/// Identifier of the backend node to highlight.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? BackendNodeId { get; set; }
		/// <summary>
		/// JavaScript object id of the node to be highlighted.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ObjectId { get; set; }
	}
}
