using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Debugger
{
	[Obsolete]

	[SupportedBy("Chrome")]
	public class PauseOnAsyncCallCommand: ICommand<PauseOnAsyncCallCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.PauseOnAsyncCall;
		/// <summary>
		/// Debugger will pause when async call with given stack trace is started.
		/// </summary>
		public Runtime.StackTraceId ParentStackTraceId { get; set; }
	}
}
