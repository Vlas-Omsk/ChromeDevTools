using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Debugger
{
	/// <summary>
	/// Steps over the statement.
	/// </summary>

	[SupportedBy("Chrome")]
	public class StepOverCommandParams: ICommandParams<StepOverCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.StepOver;
		/// <summary>
		/// The skipList specifies location ranges that should be skipped on step over.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public LocationRange[] SkipList { get; set; }
	}
}
