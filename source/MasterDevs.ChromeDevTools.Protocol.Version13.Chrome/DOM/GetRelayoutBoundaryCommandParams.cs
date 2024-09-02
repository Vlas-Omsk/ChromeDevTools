using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Returns the id of the nearest ancestor that is a relayout boundary.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetRelayoutBoundaryCommandParams: ICommandParams<GetRelayoutBoundaryCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.GetRelayoutBoundary;
		/// <summary>
		/// Id of the node.
		/// </summary>
		public long NodeId { get; set; }
	}
}
