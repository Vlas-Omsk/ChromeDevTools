using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Debugger
{
	/// <summary>
	/// Steps over the statement.
	/// </summary>

	[SupportedBy("IOS")]
	public class StepOverCommandParams: ICommandParams<StepOverCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.StepOver;
	}
}
