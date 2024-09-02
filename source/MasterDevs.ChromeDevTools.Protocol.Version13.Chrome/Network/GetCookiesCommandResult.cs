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
	public class GetCookiesCommandResult : ICommandResult
	{
		/// <summary>
		/// Array of cookie objects.
		/// </summary>
		public Cookie[] Cookies { get; set; }
	}
}
