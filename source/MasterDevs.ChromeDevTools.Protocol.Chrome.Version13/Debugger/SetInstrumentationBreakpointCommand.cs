using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Debugger
{
	/// <summary>
	/// Sets instrumentation breakpoint.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetInstrumentationBreakpointCommand: ICommand<SetInstrumentationBreakpointCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.SetInstrumentationBreakpoint;
		/// <summary>
		/// Instrumentation name.
		/// </summary>
		public string Instrumentation { get; set; }
	}
}
