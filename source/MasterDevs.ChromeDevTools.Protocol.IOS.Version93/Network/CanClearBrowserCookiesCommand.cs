using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Network
{
	/// <summary>
	/// Tells whether clearing browser cookies is supported.
	/// </summary>

	[SupportedBy("IOS")]
	public class CanClearBrowserCookiesCommand: ICommand<CanClearBrowserCookiesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.CanClearBrowserCookies;
	}
}
