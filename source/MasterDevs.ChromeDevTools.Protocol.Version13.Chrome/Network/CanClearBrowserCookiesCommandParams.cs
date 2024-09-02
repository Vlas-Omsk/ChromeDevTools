using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Tells whether clearing browser cookies is supported.
	/// </summary>
	[Obsolete]

	[SupportedBy("Chrome")]
	public class CanClearBrowserCookiesCommandParams: ICommandParams<CanClearBrowserCookiesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.CanClearBrowserCookies;
	}
}
