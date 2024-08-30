using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Sets node value for a node with given id.
	/// </summary>
	[Command(ProtocolName.DOM.SetNodeValue)]
	[SupportedBy("iOS")]
	public class SetNodeValueCommand: ICommandParams<SetNodeValueCommandResponse>
	{
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
