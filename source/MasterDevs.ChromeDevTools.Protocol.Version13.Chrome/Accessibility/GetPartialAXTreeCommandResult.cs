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
	public class GetPartialAXTreeCommandResult : ICommandResult
	{
		/// <summary>
		/// The `Accessibility.AXNode` for this DOM node, if it exists, plus its ancestors, siblings and
		/// children, if requested.
		/// </summary>
		public AXNode[] Nodes { get; set; }
	}
}
