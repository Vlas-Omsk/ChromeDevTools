using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Console
{
	/// <summary>
	/// Enables console to refer to the node with given id via $0 (see Command Line API for more details).
	/// </summary>

	[SupportedBy("IOS")]
	public class AddInspectedNodeCommandParams: ICommandParams<AddInspectedNodeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Console.AddInspectedNode;
		/// <summary>
		/// DOM node id to be accessible by means of $0 command line API.
		/// </summary>
		public long NodeId { get; set; }
	}
}
