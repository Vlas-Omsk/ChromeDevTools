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
	public class GetAXNodeAndAncestorsCommandResult : ICommandResult
	{
		/// <summary>
		/// Nodes
		/// </summary>
		public AXNode[] Nodes { get; set; }
	}
}
