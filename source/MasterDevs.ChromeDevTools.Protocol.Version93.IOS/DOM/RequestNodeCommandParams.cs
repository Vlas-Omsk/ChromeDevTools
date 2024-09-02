using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOM
{
	/// <summary>
	/// Requests that the node is sent to the caller given the JavaScript node object reference. All nodes that form the path from the node to the root are also sent to the client as a series of <code>setChildNodes</code> notifications.
	/// </summary>

	[SupportedBy("IOS")]
	public class RequestNodeCommandParams: ICommandParams<RequestNodeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.RequestNode;
		/// <summary>
		/// JavaScript object id to convert into node.
		/// </summary>
		public string ObjectId { get; set; }
	}
}
