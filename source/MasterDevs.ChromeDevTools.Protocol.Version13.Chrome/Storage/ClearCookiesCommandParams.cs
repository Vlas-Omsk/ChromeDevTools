using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Storage
{
	/// <summary>
	/// Clears cookies.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ClearCookiesCommandParams: ICommandParams<ClearCookiesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Storage.ClearCookies;
		/// <summary>
		/// Browser context to use when called on the browser endpoint.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string BrowserContextId { get; set; }
	}
}
