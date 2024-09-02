using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOM
{
	/// <summary>
	/// Sets node value for a node with given id.
	/// </summary>

	[SupportedBy("IOS")]
	public class SetNodeValueCommandParams: ICommandParams<SetNodeValueCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.SetNodeValue;
		/// <summary>
		/// Id of the node to set value for.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// New node's value.
		/// </summary>
		public string Value { get; set; }
	}
}
