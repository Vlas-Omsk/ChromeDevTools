using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Network
{
	/// <summary>
	/// Clears browser cookies.
	/// </summary>

	[SupportedBy("IOS")]
	public class ClearBrowserCookiesCommand: ICommand<ClearBrowserCookiesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.ClearBrowserCookies;
	}
}
