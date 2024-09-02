using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOMDebugger
{
	/// <summary>
	/// Removes breakpoint on particular native event.
	/// </summary>

	[SupportedBy("Chrome")]
	public class RemoveInstrumentationBreakpointCommandParams: ICommandParams<RemoveInstrumentationBreakpointCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOMDebugger.RemoveInstrumentationBreakpoint;
		/// <summary>
		/// Instrumentation name to stop on.
		/// </summary>
		public string EventName { get; set; }
	}
}
