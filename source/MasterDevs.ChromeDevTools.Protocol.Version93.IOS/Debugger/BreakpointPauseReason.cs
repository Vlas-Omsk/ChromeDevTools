using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Debugger
{
	/// <summary>
	/// The pause reason auxiliary data when paused because of hitting a breakpoint.
	/// </summary>
	[SupportedBy("IOS")]
	public class BreakpointPauseReason
	{
		/// <summary>
		/// The identifier of the breakpoint causing the pause.
		/// </summary>
		public string BreakpointId { get; set; }
	}
}