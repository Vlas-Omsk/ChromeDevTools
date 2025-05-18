using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOM
{
	/// <summary>
	/// Enables console to refer to the node with given id via $x (see Command Line API for more details
	/// $x functions).
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetInspectedNodeCommand: ICommand<SetInspectedNodeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.SetInspectedNode;
		/// <summary>
		/// DOM node id to be accessible by means of $x command line API.
		/// </summary>
		public long NodeId { get; set; }
	}
}
