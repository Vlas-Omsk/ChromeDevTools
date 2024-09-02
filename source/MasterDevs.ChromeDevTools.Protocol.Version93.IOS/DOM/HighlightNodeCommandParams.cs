using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOM
{
	/// <summary>
	/// Highlights DOM node with given id or with the given JavaScript object wrapper. Either nodeId or objectId must be specified.
	/// </summary>

	[SupportedBy("IOS")]
	public class HighlightNodeCommandParams: ICommandParams<HighlightNodeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.HighlightNode;
		/// <summary>
		/// A descriptor for the highlight appearance.
		/// </summary>
		public HighlightConfig HighlightConfig { get; set; }
		/// <summary>
		/// Identifier of the node to highlight.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? NodeId { get; set; }
		/// <summary>
		/// JavaScript object id of the node to be highlighted.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ObjectId { get; set; }
	}
}
