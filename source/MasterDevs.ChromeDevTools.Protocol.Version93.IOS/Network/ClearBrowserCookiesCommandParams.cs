using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Network
{
	/// <summary>
	/// Clears browser cookies.
	/// </summary>

	[SupportedBy("IOS")]
	public class ClearBrowserCookiesCommandParams: ICommandParams<ClearBrowserCookiesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.ClearBrowserCookies;
	}
}
