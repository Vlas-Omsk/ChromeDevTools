using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Debugger
{
	/// <summary>
	/// Steps into the function call.
	/// </summary>

	[SupportedBy("IOS")]
	public class StepIntoCommandParams: ICommandParams<StepIntoCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.StepInto;
	}
}
