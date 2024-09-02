using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Target
{
	/// <summary>
	/// Returns all browser contexts created with `Target.createBrowserContext` method.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetBrowserContextsCommandResult : ICommandResult
	{
		/// <summary>
		/// An array of browser context ids.
		/// </summary>
		public string[] BrowserContextIds { get; set; }
	}
}
