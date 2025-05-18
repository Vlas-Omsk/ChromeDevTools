using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Database
{
	/// <summary>
	/// Disables database tracking, prevents database events from being sent to the client.
	/// </summary>

	[SupportedBy("Chrome")]
	public class DisableCommand: ICommand<DisableCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Database.Disable;
	}
}
