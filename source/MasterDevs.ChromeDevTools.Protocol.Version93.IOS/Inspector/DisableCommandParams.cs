using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Inspector
{
	/// <summary>
	/// Disables inspector domain notifications.
	/// </summary>

	[SupportedBy("IOS")]
	public class DisableCommandParams: ICommandParams<DisableCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Inspector.Disable;
	}
}
