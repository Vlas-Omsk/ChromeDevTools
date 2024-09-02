using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Removes node with given id.
	/// </summary>

	[SupportedBy("Chrome")]
	public class RemoveNodeCommandParams: ICommandParams<RemoveNodeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.RemoveNode;
		/// <summary>
		/// Id of the node to remove.
		/// </summary>
		public long NodeId { get; set; }
	}
}
