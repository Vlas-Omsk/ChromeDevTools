using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Pauses page execution. Can be resumed using generic Runtime.runIfWaitingForDebugger.
	/// </summary>

	[SupportedBy("Chrome")]
	public class WaitForDebuggerCommandParams: ICommandParams<WaitForDebuggerCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.WaitForDebugger;
	}
}
