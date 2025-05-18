using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.DOMDebugger
{
	/// <summary>
	/// Removes breakpoint on particular DOM event.
	/// </summary>

	[SupportedBy("IOS")]
	public class RemoveEventListenerBreakpointCommand: ICommand<RemoveEventListenerBreakpointCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOMDebugger.RemoveEventListenerBreakpoint;
		/// <summary>
		/// Event name.
		/// </summary>
		public string EventName { get; set; }
	}
}
