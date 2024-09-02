using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Overlay
{
	/// <summary>
	/// For Persistent Grid testing.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetGridHighlightObjectsForTestCommandResult : ICommandResult
	{
		/// <summary>
		/// Grid Highlight data for the node ids provided.
		/// </summary>
		public object Highlights { get; set; }
	}
}
