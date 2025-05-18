using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Console
{
	/// <summary>
	/// Enables console to refer to the node with given id via $0 (see Command Line API for more details).
	/// </summary>

	[SupportedBy("IOS")]
	public class AddInspectedNodeCommandResult : ICommandResult
	{
	}
}
