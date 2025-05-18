using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.DOM
{
	/// <summary>
	/// Removes node with given id.
	/// </summary>

	[SupportedBy("IOS")]
	public class RemoveNodeCommand: ICommand<RemoveNodeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.RemoveNode;
		/// <summary>
		/// Id of the node to remove.
		/// </summary>
		public long NodeId { get; set; }
	}
}
