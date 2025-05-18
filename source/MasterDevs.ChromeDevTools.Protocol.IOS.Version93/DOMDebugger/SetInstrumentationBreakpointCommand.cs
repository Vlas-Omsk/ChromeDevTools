using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.DOMDebugger
{
	/// <summary>
	/// Sets breakpoint on particular native event.
	/// </summary>

	[SupportedBy("IOS")]
	public class SetInstrumentationBreakpointCommand: ICommand<SetInstrumentationBreakpointCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOMDebugger.SetInstrumentationBreakpoint;
		/// <summary>
		/// Instrumentation name to stop on.
		/// </summary>
		public string EventName { get; set; }
	}
}
