using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Debugger
{
	/// <summary>
	/// Removes JavaScript breakpoint.
	/// </summary>

	[SupportedBy("Chrome")]
	public class RemoveBreakpointCommandParams: ICommandParams<RemoveBreakpointCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.RemoveBreakpoint;
		/// <summary>
		/// BreakpointId
		/// </summary>
		public string BreakpointId { get; set; }
	}
}
