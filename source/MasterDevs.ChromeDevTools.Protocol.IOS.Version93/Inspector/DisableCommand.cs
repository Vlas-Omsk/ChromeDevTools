using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Inspector
{
	/// <summary>
	/// Disables inspector domain notifications.
	/// </summary>

	[SupportedBy("IOS")]
	public class DisableCommand: ICommand<DisableCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Inspector.Disable;
	}
}
