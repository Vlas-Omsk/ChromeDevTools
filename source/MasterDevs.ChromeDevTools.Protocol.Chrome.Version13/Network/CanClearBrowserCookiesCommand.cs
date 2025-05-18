using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Network
{
	/// <summary>
	/// Tells whether clearing browser cookies is supported.
	/// </summary>
	[Obsolete]

	[SupportedBy("Chrome")]
	public class CanClearBrowserCookiesCommand: ICommand<CanClearBrowserCookiesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.CanClearBrowserCookies;
	}
}
