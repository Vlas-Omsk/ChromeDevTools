using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Debugger
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
