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
	public class GetStackTraceCommandParams: ICommandParams<GetStackTraceCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.GetStackTrace;
		/// <summary>
		/// StackTraceId
		/// </summary>
		public Runtime.StackTraceId StackTraceId { get; set; }
	}
}
