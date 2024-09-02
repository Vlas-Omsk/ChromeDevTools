using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOM
{
	/// <summary>
	/// Removes node with given id.
	/// </summary>

	[SupportedBy("IOS")]
	public class RemoveNodeCommandParams: ICommandParams<RemoveNodeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.RemoveNode;
		/// <summary>
		/// Id of the node to remove.
		/// </summary>
		public long NodeId { get; set; }
	}
}
