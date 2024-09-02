using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Disables network tracking, prevents network events from being sent to the client.
	/// </summary>

	[SupportedBy("Chrome")]
	public class DisableCommandResult : ICommandResult
	{
	}
}
