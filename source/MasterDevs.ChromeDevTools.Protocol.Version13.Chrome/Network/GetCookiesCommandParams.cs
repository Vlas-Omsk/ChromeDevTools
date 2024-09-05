using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Returns all browser cookies for the current URL. Depending on the backend support, will return
	/// detailed cookie information in the `cookies` field.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetCookiesCommandParams: ICommandParams<GetCookiesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.GetCookies;
		/// <summary>
		/// The list of URLs for which applicable cookies will be fetched.
		/// If not specified, it's assumed to be set to the list containing
		/// the URLs of the page and all of its subframes.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] Urls { get; set; }
	}
}