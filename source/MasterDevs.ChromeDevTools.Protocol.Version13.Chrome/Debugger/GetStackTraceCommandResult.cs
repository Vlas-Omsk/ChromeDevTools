using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Debugger
{
	/// <summary>
	/// Returns stack trace with given `stackTraceId`.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetStackTraceCommandResult : ICommandResult
	{
		/// <summary>
		/// StackTrace
		/// </summary>
		public Runtime.StackTrace StackTrace { get; set; }
	}
}
