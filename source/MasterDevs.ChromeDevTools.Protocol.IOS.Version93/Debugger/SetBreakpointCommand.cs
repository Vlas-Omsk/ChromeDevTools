using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Debugger
{
	/// <summary>
	/// Sets JavaScript breakpoint at a given location.
	/// </summary>

	[SupportedBy("IOS")]
	public class SetBreakpointCommand: ICommand<SetBreakpointCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.SetBreakpoint;
		/// <summary>
		/// Location to set breakpoint in.
		/// </summary>
		public Location Location { get; set; }
		/// <summary>
		/// Options to apply to this breakpoint to modify its behavior.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public BreakpointOptions Options { get; set; }
	}
}
