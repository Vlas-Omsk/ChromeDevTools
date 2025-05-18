using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Accessibility
{
	/// <summary>
	/// Fetches the root node.
	/// Requires `enable()` to have been called previously.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetRootAXNodeCommandResult : ICommandResult
	{
		/// <summary>
		/// Node
		/// </summary>
		public AXNode Node { get; set; }
	}
}
