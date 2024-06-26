using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Sets node name for a node with given id.
	/// </summary>
	[Command(ProtocolName.DOM.SetNodeName)]
	[SupportedBy("iOS")]
	public class SetNodeNameCommand: IProtocolCommand<SetNodeNameCommandResponse>
	{
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
