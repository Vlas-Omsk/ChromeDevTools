using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Executes <code>querySelector</code> on a given node.
	/// </summary>
	[Command(ProtocolName.DOM.QuerySelector)]
	[SupportedBy("iOS")]
	public class QuerySelectorCommand: IProtocolCommand<QuerySelectorCommandResponse>
	{
		/// <summary>
		/// Id of the node to query upon.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Selector string.
		/// </summary>
		public string Selector { get; set; }
	}
}
