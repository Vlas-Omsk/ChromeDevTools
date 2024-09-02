using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Debugger
{
	/// <summary>
	/// Enables debugger for the given page. Clients should not assume that the debugging has been enabled until the result for this command is received.
	/// </summary>

	[SupportedBy("IOS")]
	public class EnableCommandResult : ICommandResult
	{
	}
}
