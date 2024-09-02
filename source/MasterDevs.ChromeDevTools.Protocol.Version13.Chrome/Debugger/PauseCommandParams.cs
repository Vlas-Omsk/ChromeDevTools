using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Debugger
{
	/// <summary>
	/// Stops on the next JavaScript statement.
	/// </summary>

	[SupportedBy("Chrome")]
	public class PauseCommandParams: ICommandParams<PauseCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.Pause;
	}
}
