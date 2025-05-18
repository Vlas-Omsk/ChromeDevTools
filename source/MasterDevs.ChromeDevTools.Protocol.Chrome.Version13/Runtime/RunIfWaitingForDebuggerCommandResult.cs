using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Runtime
{
	/// <summary>
	/// Tells inspected instance to run if it was waiting for debugger to attach.
	/// </summary>

	[SupportedBy("Chrome")]
	public class RunIfWaitingForDebuggerCommandResult : ICommandResult
	{
	}
}
