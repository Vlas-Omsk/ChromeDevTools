using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Enables console to refer to the node with given id via $x (see Command Line API for more details
	/// $x functions).
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetInspectedNodeCommandParams: ICommandParams<SetInspectedNodeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.SetInspectedNode;
		/// <summary>
		/// DOM node id to be accessible by means of $x command line API.
		/// </summary>
		public long NodeId { get; set; }
	}
}
