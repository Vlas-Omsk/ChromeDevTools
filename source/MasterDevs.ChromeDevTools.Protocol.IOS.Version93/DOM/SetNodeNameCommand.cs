using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.DOM
{
	/// <summary>
	/// Sets node name for a node with given id.
	/// </summary>

	[SupportedBy("IOS")]
	public class SetNodeNameCommand: ICommand<SetNodeNameCommandResult>
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
