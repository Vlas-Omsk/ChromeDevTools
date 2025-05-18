using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOMDebugger
{
	/// <summary>
	/// Removes DOM breakpoint that was set using `setDOMBreakpoint`.
	/// </summary>

	[SupportedBy("Chrome")]
	public class RemoveDOMBreakpointCommand: ICommand<RemoveDOMBreakpointCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOMDebugger.RemoveDOMBreakpoint;
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
