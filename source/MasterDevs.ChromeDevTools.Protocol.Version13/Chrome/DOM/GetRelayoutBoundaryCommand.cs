using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Returns the id of the nearest ancestor that is a relayout boundary.
	/// </summary>
	[Command(ProtocolName.DOM.GetRelayoutBoundary)]
	[SupportedBy("Chrome")]
	public class GetRelayoutBoundaryCommand: IProtocolCommand<GetRelayoutBoundaryCommandResponse>
	{
		/// <summary>
		/// Id of the node.
		/// </summary>
		public long NodeId { get; set; }
	}
}
