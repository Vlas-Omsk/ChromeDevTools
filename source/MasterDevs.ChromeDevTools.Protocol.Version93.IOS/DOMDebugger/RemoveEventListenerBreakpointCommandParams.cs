using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOMDebugger
{
	/// <summary>
	/// Removes breakpoint on particular DOM event.
	/// </summary>

	[SupportedBy("IOS")]
	public class RemoveEventListenerBreakpointCommandParams: ICommandParams<RemoveEventListenerBreakpointCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOMDebugger.RemoveEventListenerBreakpoint;
		/// <summary>
		/// Event name.
		/// </summary>
		public string EventName { get; set; }
	}
}
