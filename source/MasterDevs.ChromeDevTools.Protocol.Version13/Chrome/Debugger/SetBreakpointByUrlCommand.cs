using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Sets JavaScript breakpoint at given location specified either by URL or URL regex. Once this
	/// command is issued, all existing parsed scripts will have breakpoints resolved and returned in
	/// `locations` property. Further matching script parsing will result in subsequent
	/// `breakpointResolved` events issued. This logical breakpoint will survive page reloads.
	/// </summary>
	[Command(ProtocolName.Debugger.SetBreakpointByUrl)]
	[SupportedBy("Chrome")]
	public class SetBreakpointByUrlCommand: IProtocolCommand<SetBreakpointByUrlCommandResponse>
	{
		/// <summary>
		/// Line number to set breakpoint at.
		/// </summary>
		public long LineNumber { get; set; }
		/// <summary>
		/// URL of the resources to set breakpoint on.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Url { get; set; }
		/// <summary>
		/// Regex pattern for the URLs of the resources to set breakpoints on. Either `url` or
		/// `urlRegex` must be specified.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string UrlRegex { get; set; }
		/// <summary>
		/// Script hash of the resources to set breakpoint on.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ScriptHash { get; set; }
		/// <summary>
		/// Offset in the line to set breakpoint at.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ColumnNumber { get; set; }
		/// <summary>
		/// Expression to use as a breakpoint condition. When specified, debugger will only stop on the
		/// breakpoint if this expression evaluates to true.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Condition { get; set; }
	}
}
