using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Console
{
	/// <summary>
	/// Enables console domain, sends the messages collected so far to the client by means of the <code>messageAdded</code> notification.
	/// </summary>

	[SupportedBy("IOS")]
	public class EnableCommandResult : ICommandResult
	{
	}
}
