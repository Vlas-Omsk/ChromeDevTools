using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Debugger
{
	/// <summary>
	/// Sets JavaScript breakpoint at a given location.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetBreakpointCommandParams: ICommandParams<SetBreakpointCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.SetBreakpoint;
		/// <summary>
		/// Location to set breakpoint in.
		/// </summary>
		public Location Location { get; set; }
		/// <summary>
		/// Expression to use as a breakpoint condition. When specified, debugger will only stop on the
		/// breakpoint if this expression evaluates to true.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Condition { get; set; }
	}
}
