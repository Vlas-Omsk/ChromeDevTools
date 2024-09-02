using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Memory
{

	[SupportedBy("Chrome")]
	public class GetDOMCountersCommandResult : ICommandResult
	{
		/// <summary>
		/// Documents
		/// </summary>
		public long Documents { get; set; }
		/// <summary>
		/// Nodes
		/// </summary>
		public long Nodes { get; set; }
		/// <summary>
		/// JsEventListeners
		/// </summary>
		public long JsEventListeners { get; set; }
	}
}
