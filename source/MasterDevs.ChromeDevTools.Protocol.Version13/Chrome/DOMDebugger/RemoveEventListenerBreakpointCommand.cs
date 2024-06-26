using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMDebugger
{
	/// <summary>
	/// Removes breakpoint on particular DOM event.
	/// </summary>
	[Command(ProtocolName.DOMDebugger.RemoveEventListenerBreakpoint)]
	[SupportedBy("Chrome")]
	public class RemoveEventListenerBreakpointCommand: IProtocolCommand<RemoveEventListenerBreakpointCommandResponse>
	{
		/// <summary>
		/// Event name.
		/// </summary>
		public string EventName { get; set; }
		/// <summary>
		/// EventTarget interface name.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string TargetName { get; set; }
	}
}
