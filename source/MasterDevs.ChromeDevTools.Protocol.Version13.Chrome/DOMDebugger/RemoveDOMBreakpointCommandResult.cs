using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOMDebugger
{
	/// <summary>
	/// Removes DOM breakpoint that was set using `setDOMBreakpoint`.
	/// </summary>

	[SupportedBy("Chrome")]
	public class RemoveDOMBreakpointCommandResult : ICommandResult
	{
	}
}
