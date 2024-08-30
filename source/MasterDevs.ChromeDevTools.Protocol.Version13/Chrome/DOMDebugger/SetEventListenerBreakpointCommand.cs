using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMDebugger
{
	/// <summary>
	/// Sets breakpoint on particular DOM event.
	/// </summary>
	[Command(ProtocolName.DOMDebugger.SetEventListenerBreakpoint)]
	[SupportedBy("Chrome")]
	public class SetEventListenerBreakpointCommand: ICommandParams<SetEventListenerBreakpointCommandResponse>
	{
		/// <summary>
		/// DOM Event name to stop on (any DOM event will do).
		/// </summary>
		public string EventName { get; set; }
		/// <summary>
		/// EventTarget interface name to stop on. If equal to `"*"` or not provided, will stop on any
		/// EventTarget.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string TargetName { get; set; }
	}
}
