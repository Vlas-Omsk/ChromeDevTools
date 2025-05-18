using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.DOMDebugger
{
	/// <summary>
	/// Sets breakpoint on particular operation with DOM.
	/// </summary>

	[SupportedBy("IOS")]
	public class SetDOMBreakpointCommand: ICommand<SetDOMBreakpointCommandResult>
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
