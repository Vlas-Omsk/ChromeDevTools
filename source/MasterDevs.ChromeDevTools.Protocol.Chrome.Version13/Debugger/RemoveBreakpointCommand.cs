using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Debugger
{
	/// <summary>
	/// Removes JavaScript breakpoint.
	/// </summary>

	[SupportedBy("Chrome")]
	public class RemoveBreakpointCommand: ICommand<RemoveBreakpointCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.RemoveBreakpoint;
		/// <summary>
		/// BreakpointId
		/// </summary>
		public string BreakpointId { get; set; }
	}
}
