using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOMDebugger
{
	/// <summary>
	/// Removes DOM breakpoint that was set using <code>setDOMBreakpoint</code>.
	/// </summary>

	[SupportedBy("IOS")]
	public class RemoveDOMBreakpointCommandParams: ICommandParams<RemoveDOMBreakpointCommandResult>
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
