using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.EventBreakpoints
{
	/// <summary>
	/// Removes breakpoint on particular native event.
	/// </summary>

	[SupportedBy("Chrome")]
	public class RemoveInstrumentationBreakpointCommand: ICommand<RemoveInstrumentationBreakpointCommandResult>
	{
		public string MethodName { get; } = ProtocolName.EventBreakpoints.RemoveInstrumentationBreakpoint;
		/// <summary>
		/// Instrumentation name to stop on.
		/// </summary>
		public string EventName { get; set; }
	}
}
