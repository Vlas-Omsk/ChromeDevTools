using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Enables network tracking, network events will now be delivered to the client.
	/// </summary>

	[SupportedBy("Chrome")]
	public class EnableCommandResult : ICommandResult
	{
	}
}
