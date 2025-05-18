using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Debugger
{
	/// <summary>
	/// Steps out of the function call.
	/// </summary>

	[SupportedBy("Chrome")]
	public class StepOutCommand: ICommand<StepOutCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.StepOut;
	}
}
