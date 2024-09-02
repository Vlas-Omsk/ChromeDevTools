using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Disables page domain notifications.
	/// </summary>

	[SupportedBy("Chrome")]
	public class DisableCommandParams: ICommandParams<DisableCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.Disable;
	}
}
