using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Accessibility
{
	/// <summary>
	/// Fetches a node and all ancestors up to and including the root.
	/// Requires `enable()` to have been called previously.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetAXNodeAndAncestorsCommandParams: ICommandParams<GetAXNodeAndAncestorsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Accessibility.GetAXNodeAndAncestors;
		/// <summary>
		/// Identifier of the node to get.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? NodeId { get; set; }
		/// <summary>
		/// Identifier of the backend node to get.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? BackendNodeId { get; set; }
		/// <summary>
		/// JavaScript object id of the node wrapper to get.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ObjectId { get; set; }
	}
}
