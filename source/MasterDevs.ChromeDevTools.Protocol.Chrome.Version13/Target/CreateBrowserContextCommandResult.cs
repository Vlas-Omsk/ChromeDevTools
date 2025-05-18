using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Target
{
	/// <summary>
	/// Creates a new empty BrowserContext. Similar to an incognito profile but you can have more than
	/// one.
	/// </summary>

	[SupportedBy("Chrome")]
	public class CreateBrowserContextCommandResult : ICommandResult
	{
		/// <summary>
		/// The id of the context created.
		/// </summary>
		public string BrowserContextId { get; set; }
	}
}
