using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOM
{
	/// <summary>
	/// Sets node name for a node with given id.
	/// </summary>

	[SupportedBy("IOS")]
	public class SetNodeNameCommandParams: ICommandParams<SetNodeNameCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.SetNodeName;
		/// <summary>
		/// Id of the node to set name for.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// New node's name.
		/// </summary>
		public string Name { get; set; }
	}
}
