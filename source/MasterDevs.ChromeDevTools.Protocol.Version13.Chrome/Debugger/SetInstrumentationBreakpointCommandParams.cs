using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Debugger
{
	/// <summary>
	/// Sets instrumentation breakpoint.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetInstrumentationBreakpointCommandParams: ICommandParams<SetInstrumentationBreakpointCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.SetInstrumentationBreakpoint;
		/// <summary>
		/// Instrumentation name.
		/// </summary>
		public string Instrumentation { get; set; }
	}
}
