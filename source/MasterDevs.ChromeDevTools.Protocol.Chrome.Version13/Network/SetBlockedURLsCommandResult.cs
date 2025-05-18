using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Network
{
	/// <summary>
	/// Blocks URLs from loading.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetBlockedURLsCommandResult : ICommandResult
	{
	}
}
