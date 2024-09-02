using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Debugger
{
	/// <summary>
	/// Sets JavaScript breakpoint at a given location.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetBreakpointCommandResult : ICommandResult
	{
		/// <summary>
		/// Id of the created breakpoint for further reference.
		/// </summary>
		public string BreakpointId { get; set; }
		/// <summary>
		/// Location this breakpoint resolved into.
		/// </summary>
		public Location ActualLocation { get; set; }
	}
}
