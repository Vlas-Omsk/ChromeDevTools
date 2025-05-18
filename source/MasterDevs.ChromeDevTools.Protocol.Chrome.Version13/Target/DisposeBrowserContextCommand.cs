using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Target
{
	/// <summary>
	/// Deletes a BrowserContext. All the belonging pages will be closed without calling their
	/// beforeunload hooks.
	/// </summary>

	[SupportedBy("Chrome")]
	public class DisposeBrowserContextCommand: ICommand<DisposeBrowserContextCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Target.DisposeBrowserContext;
		/// <summary>
		/// BrowserContextId
		/// </summary>
		public string BrowserContextId { get; set; }
	}
}
