using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Debugger
{
	/// <summary>
	/// Fired when breakpoint is resolved to an actual script and location.
	/// </summary>
	[EventName(ProtocolName.Debugger.BreakpointResolved)]
	[SupportedBy("IOS")]
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
