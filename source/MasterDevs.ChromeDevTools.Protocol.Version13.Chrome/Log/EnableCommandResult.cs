using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Log
{
	/// <summary>
	/// Enables log domain, sends the entries collected so far to the client by means of the
	/// `entryAdded` notification.
	/// </summary>

	[SupportedBy("Chrome")]
	public class EnableCommandResult : ICommandResult
	{
	}
}
