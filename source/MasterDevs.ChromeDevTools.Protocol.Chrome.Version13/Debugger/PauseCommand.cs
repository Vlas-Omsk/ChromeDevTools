using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Debugger
{
	/// <summary>
	/// Stops on the next JavaScript statement.
	/// </summary>

	[SupportedBy("Chrome")]
	public class PauseCommand: ICommand<PauseCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.Pause;
	}
}
