using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Debugger
{
	/// <summary>
	/// Fired when a "sound" breakpoint action is triggered on a breakpoint.
	/// </summary>
	[EventName(ProtocolName.Debugger.PlayBreakpointActionSound)]
	[SupportedBy("IOS")]
	public class PlayBreakpointActionSoundEventParams : IEventParams
	{
		/// <summary>
		/// Breakpoint action identifier.
		/// </summary>
		public long BreakpointActionId { get; set; }
	}
}
