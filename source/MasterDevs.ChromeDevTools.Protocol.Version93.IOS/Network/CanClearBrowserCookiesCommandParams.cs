using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Network
{
	/// <summary>
	/// Tells whether clearing browser cookies is supported.
	/// </summary>

	[SupportedBy("IOS")]
	public class CanClearBrowserCookiesCommandParams: ICommandParams<CanClearBrowserCookiesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.CanClearBrowserCookies;
	}
}
