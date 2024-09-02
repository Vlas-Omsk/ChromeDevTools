using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Runtime
{
	/// <summary>
	/// Tells inspected instance to run if it was waiting for debugger to attach.
	/// </summary>

	[SupportedBy("Chrome")]
	public class RunIfWaitingForDebuggerCommandParams: ICommandParams<RunIfWaitingForDebuggerCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Runtime.RunIfWaitingForDebugger;
	}
}
