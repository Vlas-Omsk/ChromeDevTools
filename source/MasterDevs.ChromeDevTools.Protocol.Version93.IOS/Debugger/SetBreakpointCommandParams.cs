using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Debugger
{
	/// <summary>
	/// Sets JavaScript breakpoint at a given location.
	/// </summary>

	[SupportedBy("IOS")]
	public class SetBreakpointCommandParams: ICommandParams<SetBreakpointCommandResult>
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
