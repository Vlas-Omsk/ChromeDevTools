using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Debugger
{
	/// <summary>
	/// Steps over the statement.
	/// </summary>

	[SupportedBy("IOS")]
	public class StepOverCommand: ICommand<StepOverCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.StepOver;
	}
}
