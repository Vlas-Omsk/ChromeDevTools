using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Target
{
	/// <summary>
	/// Deletes a BrowserContext. All the belonging pages will be closed without calling their
	/// beforeunload hooks.
	/// </summary>

	[SupportedBy("Chrome")]
	public class DisposeBrowserContextCommandResult : ICommandResult
	{
	}
}