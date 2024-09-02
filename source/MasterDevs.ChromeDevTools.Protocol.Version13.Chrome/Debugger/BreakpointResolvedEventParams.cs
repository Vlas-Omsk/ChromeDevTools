using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Debugger
{
	/// <summary>
	/// Fired when breakpoint is resolved to an actual script and location.
	/// </summary>
	[EventName(ProtocolName.Debugger.BreakpointResolved)]
	[SupportedBy("Chrome")]
	public class BreakpointResolvedEventParams : IEventParams
	{
		/// <summary>
		/// Breakpoint unique identifier.
		/// </summary>
		public string BreakpointId { get; set; }
		/// <summary>
		/// Actual breakpoint location.
		/// </summary>
		public Location Location { get; set; }
	}
}
