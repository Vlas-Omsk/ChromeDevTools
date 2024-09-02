using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.CSS
{
	/// <summary>
	/// Enables the CSS agent for the given page. Clients should not assume that the CSS agent has been enabled until the result of this command is received.
	/// </summary>

	[SupportedBy("IOS")]
	public class EnableCommandParams: ICommandParams<EnableCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.Enable;
	}
}
