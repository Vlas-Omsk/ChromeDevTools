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
	public class GetStackTraceCommand: ICommand<GetStackTraceCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.GetStackTrace;
		/// <summary>
		/// StackTraceId
		/// </summary>
		public Runtime.StackTraceId StackTraceId { get; set; }
	}
}
