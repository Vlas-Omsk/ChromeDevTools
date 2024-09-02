using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOM
{
	/// <summary>
	/// Requests that children of the node with given id are returned to the caller in form of <code>setChildNodes</code> events where not only immediate children are retrieved, but all children down to the specified depth.
	/// </summary>

	[SupportedBy("IOS")]
	public class RequestChildNodesCommandParams: ICommandParams<RequestChildNodesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.RequestChildNodes;
		/// <summary>
		/// Id of the node to get children for.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// The maximum depth at which children should be retrieved, defaults to 1. Use -1 for the entire subtree or provide an integer larger than 0.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Depth { get; set; }
	}
}
