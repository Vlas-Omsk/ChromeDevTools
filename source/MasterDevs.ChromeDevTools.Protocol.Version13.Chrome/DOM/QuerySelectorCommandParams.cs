using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Executes `querySelector` on a given node.
	/// </summary>

	[SupportedBy("Chrome")]
	public class QuerySelectorCommandParams: ICommandParams<QuerySelectorCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.QuerySelector;
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
