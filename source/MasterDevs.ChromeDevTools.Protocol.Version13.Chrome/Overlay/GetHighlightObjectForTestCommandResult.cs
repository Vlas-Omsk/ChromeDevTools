using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Overlay
{
	/// <summary>
	/// For testing.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetHighlightObjectForTestCommandResult : ICommandResult
	{
		/// <summary>
		/// Highlight data for the node.
		/// </summary>
		public object Highlight { get; set; }
	}
}
