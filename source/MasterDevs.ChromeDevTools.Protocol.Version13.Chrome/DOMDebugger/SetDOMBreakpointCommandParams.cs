using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOMDebugger
{
	/// <summary>
	/// Sets breakpoint on particular operation with DOM.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetDOMBreakpointCommandParams: ICommandParams<SetDOMBreakpointCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOMDebugger.SetDOMBreakpoint;
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
