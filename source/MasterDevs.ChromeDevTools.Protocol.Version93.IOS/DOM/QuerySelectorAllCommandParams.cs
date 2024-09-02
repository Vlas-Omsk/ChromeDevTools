using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOM
{
	/// <summary>
	/// Executes <code>querySelectorAll</code> on a given node.
	/// </summary>

	[SupportedBy("IOS")]
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
