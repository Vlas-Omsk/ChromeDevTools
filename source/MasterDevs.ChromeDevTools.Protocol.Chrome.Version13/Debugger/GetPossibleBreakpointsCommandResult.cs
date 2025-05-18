using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Debugger
{
	/// <summary>
	/// Returns possible locations for breakpoint. scriptId in start and end range locations should be
	/// the same.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetPossibleBreakpointsCommandResult : ICommandResult
	{
		/// <summary>
		/// List of the possible breakpoint locations.
		/// </summary>
		public BreakLocation[] Locations { get; set; }
	}
}
