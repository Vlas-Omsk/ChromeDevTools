using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOMDebugger
{
	/// <summary>
	/// Sets breakpoint on particular operation with DOM.
	/// </summary>
	[Command(ProtocolName.DOMDebugger.SetDOMBreakpoint)]
	[SupportedBy("iOS")]
	public class SetDOMBreakpointCommand: IProtocolCommand<SetDOMBreakpointCommandResponse>
	{
		/// <summary>
		/// Identifier of the node to set breakpoint on.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Type of the operation to stop upon.
		/// </summary>
		public string Type { get; set; }
	}
}
