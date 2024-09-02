using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Debugger
{
	/// <summary>
	/// Sets instrumentation breakpoint.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetInstrumentationBreakpointCommandResult : ICommandResult
	{
		/// <summary>
		/// Id of the created breakpoint for further reference.
		/// </summary>
		public string BreakpointId { get; set; }
	}
}
