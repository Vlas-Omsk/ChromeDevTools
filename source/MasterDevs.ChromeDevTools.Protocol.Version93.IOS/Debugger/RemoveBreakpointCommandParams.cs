using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Debugger
{
	/// <summary>
	/// Removes JavaScript breakpoint.
	/// </summary>

	[SupportedBy("IOS")]
	public class RemoveBreakpointCommandParams: ICommandParams<RemoveBreakpointCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.RemoveBreakpoint;
		/// <summary>
		/// BreakpointId
		/// </summary>
		public string BreakpointId { get; set; }
	}
}
