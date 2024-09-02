using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOMDebugger
{
	/// <summary>
	/// Sets breakpoint on particular DOM event.
	/// </summary>

	[SupportedBy("IOS")]
	public class SetEventListenerBreakpointCommandParams: ICommandParams<SetEventListenerBreakpointCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOMDebugger.SetEventListenerBreakpoint;
		/// <summary>
		/// DOM Event name to stop on (any DOM event will do).
		/// </summary>
		public string EventName { get; set; }
	}
}
