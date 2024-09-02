using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Debugger
{
	/// <summary>
	/// Extra options that modify breakpoint behavior.
	/// </summary>
	[SupportedBy("IOS")]
	public class BreakpointOptions
	{
		/// <summary>
		/// Expression to use as a breakpoint condition. When specified, debugger will only stop on the breakpoint if this expression evaluates to true.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Condition { get; set; }
		/// <summary>
		/// Actions to perform automatically when the breakpoint is triggered.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public BreakpointAction[] Actions { get; set; }
		/// <summary>
		/// Automatically continue after hitting this breakpoint and running actions.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? AutoContinue { get; set; }
		/// <summary>
		/// Number of times to ignore this breakpoint, before stopping on the breakpoint and running actions.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? IgnoreCount { get; set; }
	}
}
