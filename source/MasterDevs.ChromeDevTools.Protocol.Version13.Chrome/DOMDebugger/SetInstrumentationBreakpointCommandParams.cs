using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOMDebugger
{
	/// <summary>
	/// Sets breakpoint on particular native event.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetInstrumentationBreakpointCommandParams: ICommandParams<SetInstrumentationBreakpointCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOMDebugger.SetInstrumentationBreakpoint;
		/// <summary>
		/// Instrumentation name to stop on.
		/// </summary>
		public string EventName { get; set; }
	}
}
