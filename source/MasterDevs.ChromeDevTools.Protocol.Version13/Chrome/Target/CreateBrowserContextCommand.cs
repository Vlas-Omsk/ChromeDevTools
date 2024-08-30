using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Creates a new empty BrowserContext. Similar to an incognito profile but you can have more than
	/// one.
	/// </summary>
	[Command(ProtocolName.Target.CreateBrowserContext)]
	[SupportedBy("Chrome")]
	public class CreateBrowserContextCommand: ICommandParams<CreateBrowserContextCommandResponse>
	{
		/// <summary>
		/// If specified, disposes this context when debugging session disconnects.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? DisposeOnDetach { get; set; }
		/// <summary>
		/// Proxy server, similar to the one passed to --proxy-server
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ProxyServer { get; set; }
		/// <summary>
		/// Proxy bypass list, similar to the one passed to --proxy-bypass-list
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ProxyBypassList { get; set; }
		/// <summary>
		/// An optional list of origins to grant unlimited cross-origin access to.
		/// Parts of the URL other than those constituting origin are ignored.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] OriginsWithUniversalNetworkAccess { get; set; }
	}
}
