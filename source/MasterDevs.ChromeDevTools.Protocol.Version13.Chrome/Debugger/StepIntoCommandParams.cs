using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Debugger
{
	/// <summary>
	/// Steps into the function call.
	/// </summary>

	[SupportedBy("Chrome")]
	public class StepIntoCommandParams: ICommandParams<StepIntoCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.StepInto;
		/// <summary>
		/// Debugger will pause on the execution of the first async task which was scheduled
		/// before next pause.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? BreakOnAsyncCall { get; set; }
		/// <summary>
		/// The skipList specifies location ranges that should be skipped on step into.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public LocationRange[] SkipList { get; set; }
	}
}
