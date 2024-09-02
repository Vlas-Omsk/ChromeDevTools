using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOMDebugger
{
	/// <summary>
	/// Removes breakpoint from XMLHttpRequest.
	/// </summary>

	[SupportedBy("IOS")]
	public class RemoveXHRBreakpointCommandParams: ICommandParams<RemoveXHRBreakpointCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOMDebugger.RemoveXHRBreakpoint;
		/// <summary>
		/// Resource URL substring.
		/// </summary>
		public string Url { get; set; }
	}
}
