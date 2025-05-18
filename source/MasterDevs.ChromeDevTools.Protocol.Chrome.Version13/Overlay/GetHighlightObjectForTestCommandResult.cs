using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Overlay
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
