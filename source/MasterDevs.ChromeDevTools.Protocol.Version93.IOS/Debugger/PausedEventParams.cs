using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Debugger
{
	/// <summary>
	/// Fired when the virtual machine stopped on breakpoint or exception or any other stop criteria.
	/// </summary>
	[EventName(ProtocolName.Debugger.Paused)]
	[SupportedBy("IOS")]
	public class PausedEventParams : IEventParams
	{
		/// <summary>
		/// Call stack the virtual machine stopped on.
		/// </summary>
		public CallFrame[] CallFrames { get; set; }
		/// <summary>
		/// Pause reason.
		/// </summary>
		public string Reason { get; set; }
		/// <summary>
		/// Object containing break-specific auxiliary properties.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public object Data { get; set; }
	}
}
