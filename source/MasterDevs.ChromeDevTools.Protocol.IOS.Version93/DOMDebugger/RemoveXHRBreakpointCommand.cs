using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.DOMDebugger
{
	/// <summary>
	/// Removes breakpoint from XMLHttpRequest.
	/// </summary>

	[SupportedBy("IOS")]
	public class RemoveXHRBreakpointCommand: ICommand<RemoveXHRBreakpointCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOMDebugger.RemoveXHRBreakpoint;
		/// <summary>
		/// Resource URL substring.
		/// </summary>
		public string Url { get; set; }
	}
}
