using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Sets instrumentation breakpoint.
	/// </summary>
	[Command(ProtocolName.Debugger.SetInstrumentationBreakpoint)]
	[SupportedBy("Chrome")]
	public class SetInstrumentationBreakpointCommand: IProtocolCommand<SetInstrumentationBreakpointCommandResponse>
	{
		/// <summary>
		/// Instrumentation name.
		/// </summary>
		public string Instrumentation { get; set; }
	}
}
