using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Storage
{
	/// <summary>
	/// Returns all browser cookies.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetCookiesCommandParams: ICommandParams<GetCookiesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Storage.GetCookies;
		/// <summary>
		/// Browser context to use when called on the browser endpoint.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string BrowserContextId { get; set; }
	}
}
