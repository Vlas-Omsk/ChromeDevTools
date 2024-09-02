using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Console
{
	/// <summary>
	/// Does nothing.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ClearMessagesCommandParams: ICommandParams<ClearMessagesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Console.ClearMessages;
	}
}
