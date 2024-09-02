using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Blocks URLs from loading.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetBlockedURLsCommandResult : ICommandResult
	{
	}
}
