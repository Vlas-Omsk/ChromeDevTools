using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Storage
{
	/// <summary>
	/// Sets given cookies.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetCookiesCommand: ICommand<SetCookiesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Storage.SetCookies;
		/// <summary>
		/// Cookies to be set.
		/// </summary>
		public Network.CookieParam[] Cookies { get; set; }
		/// <summary>
		/// Browser context to use when called on the browser endpoint.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string BrowserContextId { get; set; }
	}
}
