using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Executes `querySelectorAll` on a given node.
	/// </summary>

	[SupportedBy("Chrome")]
	public class QuerySelectorAllCommandParams: ICommandParams<QuerySelectorAllCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.QuerySelectorAll;
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
