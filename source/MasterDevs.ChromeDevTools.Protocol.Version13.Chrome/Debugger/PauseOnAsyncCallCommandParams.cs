using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Debugger
{
	[Obsolete]

	[SupportedBy("Chrome")]
	public class PauseOnAsyncCallCommandParams: ICommandParams<PauseOnAsyncCallCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.PauseOnAsyncCall;
		/// <summary>
		/// Debugger will pause when async call with given stack trace is started.
		/// </summary>
		public Runtime.StackTraceId ParentStackTraceId { get; set; }
	}
}
