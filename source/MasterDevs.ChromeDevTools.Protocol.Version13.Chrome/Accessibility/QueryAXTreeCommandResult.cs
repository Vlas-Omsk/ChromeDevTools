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
	public class QueryAXTreeCommandResult : ICommandResult
	{
		/// <summary>
		/// A list of `Accessibility.AXNode` matching the specified attributes,
		/// including nodes that are ignored for accessibility.
		/// </summary>
		public AXNode[] Nodes { get; set; }
	}
}
