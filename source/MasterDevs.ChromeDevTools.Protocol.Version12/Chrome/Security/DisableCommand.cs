using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Security
{
	/// <summary>
	/// Disables tracking security state changes.
	/// </summary>
	[Command(ProtocolName.Security.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommand: IProtocolCommand<DisableCommandResponse>
	{
	}
}
