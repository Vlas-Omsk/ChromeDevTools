using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Debugger
{
	/// <summary>
	/// Fired when the virtual machine stopped on breakpoint or exception or any other stop criteria.
	/// </summary>
	[EventName(ProtocolName.Debugger.Paused)]
	[SupportedBy("Chrome")]
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
		/// <summary>
		/// Hit breakpoints IDs
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] HitBreakpoints { get; set; }
		/// <summary>
		/// Async stack trace, if any.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Runtime.StackTrace AsyncStackTrace { get; set; }
		/// <summary>
		/// Async stack trace, if any.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Runtime.StackTraceId AsyncStackTraceId { get; set; }
		/// <summary>
		/// Never present, will be removed.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Runtime.StackTraceId AsyncCallStackTraceId { get; set; }
	}
}
