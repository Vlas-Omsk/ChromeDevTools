using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Deletes a BrowserContext. All the belonging pages will be closed without calling their
	/// beforeunload hooks.
	/// </summary>
	[Command(ProtocolName.Target.DisposeBrowserContext)]
	[SupportedBy("Chrome")]
	public class DisposeBrowserContextCommand: IProtocolCommand<DisposeBrowserContextCommandResponse>
	{
		/// <summary>
		/// BrowserContextId
		/// </summary>
		public string BrowserContextId { get; set; }
	}
}
