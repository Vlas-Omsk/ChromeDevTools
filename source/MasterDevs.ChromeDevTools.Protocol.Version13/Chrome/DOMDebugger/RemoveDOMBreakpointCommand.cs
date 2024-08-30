using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMDebugger
{
	/// <summary>
	/// Removes DOM breakpoint that was set using `setDOMBreakpoint`.
	/// </summary>
	[Command(ProtocolName.DOMDebugger.RemoveDOMBreakpoint)]
	[SupportedBy("Chrome")]
	public class RemoveDOMBreakpointCommand: ICommandParams<RemoveDOMBreakpointCommandResponse>
	{
		/// <summary>
		/// Identifier of the node to remove breakpoint from.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Type of the breakpoint to remove.
		/// </summary>
		public string Type { get; set; }
	}
}
