using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Debugger
{
	/// <summary>
	/// Stops on the next JavaScript statement.
	/// </summary>

	[SupportedBy("IOS")]
	public class PauseCommandParams: ICommandParams<PauseCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.Pause;
	}
}
