using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Accessibility
{
	/// <summary>
	/// Fetches the accessibility node and partial accessibility tree for this DOM node, if it exists.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetPartialAXTreeCommandParams: ICommandParams<GetPartialAXTreeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Accessibility.GetPartialAXTree;
		/// <summary>
		/// Identifier of the node to get the partial accessibility tree for.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? NodeId { get; set; }
		/// <summary>
		/// Identifier of the backend node to get the partial accessibility tree for.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? BackendNodeId { get; set; }
		/// <summary>
		/// JavaScript object id of the node wrapper to get the partial accessibility tree for.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ObjectId { get; set; }
		/// <summary>
		/// Whether to fetch this node's ancestors, siblings and children. Defaults to true.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? FetchRelatives { get; set; }
	}
}
