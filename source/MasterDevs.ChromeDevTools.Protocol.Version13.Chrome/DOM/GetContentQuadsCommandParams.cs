using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Returns quads that describe node position on the page. This method
	/// might return multiple quads for inline nodes.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetContentQuadsCommandParams: ICommandParams<GetContentQuadsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.GetContentQuads;
		/// <summary>
		/// Identifier of the node.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? NodeId { get; set; }
		/// <summary>
		/// Identifier of the backend node.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? BackendNodeId { get; set; }
		/// <summary>
		/// JavaScript object id of the node wrapper.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ObjectId { get; set; }
	}
}
