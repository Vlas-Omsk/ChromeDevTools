using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOMDebugger
{
	/// <summary>
	/// Removes breakpoint on particular DOM event.
	/// </summary>

	[SupportedBy("Chrome")]
	public class RemoveEventListenerBreakpointCommandParams: ICommandParams<RemoveEventListenerBreakpointCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOMDebugger.RemoveEventListenerBreakpoint;
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
