using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Overlay
{
	/// <summary>
	/// For Source Order Viewer testing.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetSourceOrderHighlightObjectForTestCommandResult : ICommandResult
	{
		/// <summary>
		/// Source order highlight data for the node id provided.
		/// </summary>
		public object Highlight { get; set; }
	}
}
