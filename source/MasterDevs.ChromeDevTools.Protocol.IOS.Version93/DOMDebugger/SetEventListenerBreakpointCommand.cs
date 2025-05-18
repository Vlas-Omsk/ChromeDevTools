using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.DOMDebugger
{
	/// <summary>
	/// Sets breakpoint on particular DOM event.
	/// </summary>

	[SupportedBy("IOS")]
	public class SetEventListenerBreakpointCommand: ICommand<SetEventListenerBreakpointCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOMDebugger.SetEventListenerBreakpoint;
		/// <summary>
		/// DOM Event name to stop on (any DOM event will do).
		/// </summary>
		public string EventName { get; set; }
	}
}
