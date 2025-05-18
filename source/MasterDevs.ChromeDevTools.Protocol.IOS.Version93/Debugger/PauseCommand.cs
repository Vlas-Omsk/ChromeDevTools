using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Debugger
{
	/// <summary>
	/// Stops on the next JavaScript statement.
	/// </summary>

	[SupportedBy("IOS")]
	public class PauseCommand: ICommand<PauseCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.Pause;
	}
}
