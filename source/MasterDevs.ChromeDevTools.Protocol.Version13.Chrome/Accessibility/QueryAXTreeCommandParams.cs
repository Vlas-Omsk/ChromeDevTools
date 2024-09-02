using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Accessibility
{
	/// <summary>
	/// Query a DOM node's accessibility subtree for accessible name and role.
	/// This command computes the name and role for all nodes in the subtree, including those that are
	/// ignored for accessibility, and returns those that mactch the specified name and role. If no DOM
	/// node is specified, or the DOM node does not exist, the command returns an error. If neither
	/// `accessibleName` or `role` is specified, it returns all the accessibility nodes in the subtree.
	/// </summary>

	[SupportedBy("Chrome")]
	public class QueryAXTreeCommandParams: ICommandParams<QueryAXTreeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Accessibility.QueryAXTree;
		/// <summary>
		/// Identifier of the node for the root to query.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? NodeId { get; set; }
		/// <summary>
		/// Identifier of the backend node for the root to query.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? BackendNodeId { get; set; }
		/// <summary>
		/// JavaScript object id of the node wrapper for the root to query.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ObjectId { get; set; }
		/// <summary>
		/// Find nodes with this computed name.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string AccessibleName { get; set; }
		/// <summary>
		/// Find nodes with this computed role.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Role { get; set; }
	}
}
