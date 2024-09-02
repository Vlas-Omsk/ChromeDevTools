using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Sets given cookies.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetCookiesCommandParams: ICommandParams<SetCookiesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.SetCookies;
		/// <summary>
		/// Cookies to be set.
		/// </summary>
		public CookieParam[] Cookies { get; set; }
	}
}
