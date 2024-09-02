using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOMDebugger
{
	/// <summary>
	/// Sets breakpoint on XMLHttpRequest.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetXHRBreakpointCommandParams: ICommandParams<SetXHRBreakpointCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOMDebugger.SetXHRBreakpoint;
		/// <summary>
		/// Resource URL substring. All XHRs having this substring in the URL will get stopped upon.
		/// </summary>
		public string Url { get; set; }
	}
}
