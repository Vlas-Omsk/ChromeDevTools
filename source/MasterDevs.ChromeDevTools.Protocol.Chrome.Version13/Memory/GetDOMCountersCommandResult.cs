using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Memory
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
