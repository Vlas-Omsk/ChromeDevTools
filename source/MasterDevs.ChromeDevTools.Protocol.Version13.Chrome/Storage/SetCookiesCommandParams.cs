using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Storage
{
	/// <summary>
	/// Sets given cookies.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetCookiesCommandParams: ICommandParams<SetCookiesCommandResult>
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
