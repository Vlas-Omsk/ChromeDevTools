using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Returns all browser cookies for the current URL. Depending on the backend support, will return
	/// detailed cookie information in the `cookies` field.
	/// </summary>
	[CommandResponse(ProtocolName.Network.GetCookies)]
	[SupportedBy("Chrome")]
	public class GetCookiesCommandResponse
	{
		/// <summary>
		/// Array of cookie objects.
		/// </summary>
		public Cookie[] Cookies { get; set; }
	}
}
