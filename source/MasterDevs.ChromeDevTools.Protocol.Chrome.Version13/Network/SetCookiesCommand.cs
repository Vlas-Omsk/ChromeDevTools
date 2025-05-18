using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Network
{
	/// <summary>
	/// Sets given cookies.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetCookiesCommand: ICommand<SetCookiesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.SetCookies;
		/// <summary>
		/// Cookies to be set.
		/// </summary>
		public CookieParam[] Cookies { get; set; }
	}
}
