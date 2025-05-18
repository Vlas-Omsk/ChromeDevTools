using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Accessibility
{
	/// <summary>
	/// Fetches a particular accessibility node by AXNodeId.
	/// Requires `enable()` to have been called previously.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetChildAXNodesCommandResult : ICommandResult
	{
		/// <summary>
		/// Nodes
		/// </summary>
		public AXNode[] Nodes { get; set; }
	}
}
