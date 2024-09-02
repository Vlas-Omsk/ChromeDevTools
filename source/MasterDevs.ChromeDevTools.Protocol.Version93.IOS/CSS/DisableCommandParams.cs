using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.CSS
{
	/// <summary>
	/// Disables the CSS agent for the given page.
	/// </summary>

	[SupportedBy("IOS")]
	public class DisableCommandParams: ICommandParams<DisableCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.Disable;
	}
}
