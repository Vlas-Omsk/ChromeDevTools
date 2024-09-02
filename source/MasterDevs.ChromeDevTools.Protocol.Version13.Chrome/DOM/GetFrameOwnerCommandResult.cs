using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Returns iframe node that owns iframe with the given domain.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetFrameOwnerCommandResult : ICommandResult
	{
		/// <summary>
		/// Resulting node.
		/// </summary>
		public long BackendNodeId { get; set; }
		/// <summary>
		/// Id of the node at given coordinates, only when enabled and requested document.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? NodeId { get; set; }
	}
}
