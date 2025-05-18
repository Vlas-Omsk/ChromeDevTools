using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Debugger
{
	/// <summary>
	/// Disables debugger for given page.
	/// </summary>

	[SupportedBy("IOS")]
	public class DisableCommand: ICommand<DisableCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.Disable;
	}
}
