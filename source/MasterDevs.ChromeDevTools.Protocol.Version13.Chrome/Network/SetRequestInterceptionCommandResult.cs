using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Sets the requests to intercept that match the provided patterns and optionally resource types.
	/// Deprecated, please use Fetch.enable instead.
	/// </summary>
	[Obsolete]

	[SupportedBy("Chrome")]
	public class SetRequestInterceptionCommandResult : ICommandResult
	{
	}
}
