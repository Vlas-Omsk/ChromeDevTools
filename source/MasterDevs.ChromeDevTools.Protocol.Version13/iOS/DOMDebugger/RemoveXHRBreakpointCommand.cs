using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOMDebugger
{
	/// <summary>
	/// Removes breakpoint from XMLHttpRequest.
	/// </summary>
	[Command(ProtocolName.DOMDebugger.RemoveXHRBreakpoint)]
	[SupportedBy("iOS")]
	public class RemoveXHRBreakpointCommand: IProtocolCommand<RemoveXHRBreakpointCommandResponse>
	{
		/// <summary>
		/// Resource URL substring.
		/// </summary>
		public string Url { get; set; }
	}
}
