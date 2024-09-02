using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Requests that the node is sent to the caller given the JavaScript node object reference. All
	/// nodes that form the path from the node to the root are also sent to the client as a series of
	/// `setChildNodes` notifications.
	/// </summary>

	[SupportedBy("Chrome")]
	public class RequestNodeCommandParams: ICommandParams<RequestNodeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.RequestNode;
		/// <summary>
		/// JavaScript object id to convert into node.
		/// </summary>
		public string ObjectId { get; set; }
	}
}
