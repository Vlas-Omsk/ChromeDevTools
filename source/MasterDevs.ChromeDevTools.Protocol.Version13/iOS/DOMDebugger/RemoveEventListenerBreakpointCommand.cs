using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOMDebugger
{
	/// <summary>
	/// Removes breakpoint on particular DOM event.
	/// </summary>
	[Command(ProtocolName.DOMDebugger.RemoveEventListenerBreakpoint)]
	[SupportedBy("iOS")]
	public class RemoveEventListenerBreakpointCommand: IProtocolCommand<RemoveEventListenerBreakpointCommandResponse>
	{
		/// <summary>
		/// Event name.
		/// </summary>
		public string EventName { get; set; }
	}
}
