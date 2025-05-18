using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOM
{
	/// <summary>
	/// Returns the id of the nearest ancestor that is a relayout boundary.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetRelayoutBoundaryCommandResult : ICommandResult
	{
		/// <summary>
		/// Relayout boundary node id for the given node.
		/// </summary>
		public long NodeId { get; set; }
	}
}
