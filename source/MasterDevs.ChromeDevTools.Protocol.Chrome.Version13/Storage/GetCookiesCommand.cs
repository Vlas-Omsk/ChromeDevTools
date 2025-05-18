using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Storage
{
	/// <summary>
	/// Returns all browser cookies.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetCookiesCommand: ICommand<GetCookiesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Storage.GetCookies;
		/// <summary>
		/// Browser context to use when called on the browser endpoint.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string BrowserContextId { get; set; }
	}
}
