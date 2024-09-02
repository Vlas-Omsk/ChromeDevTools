using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Returns the root DOM node (and optionally the subtree) to the caller.
	/// Implicitly enables the DOM domain events for the current target.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetDocumentCommandResult : ICommandResult
	{
		/// <summary>
		/// Resulting node.
		/// </summary>
		public Node Root { get; set; }
	}
}
