using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Clears browser cookies.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ClearBrowserCookiesCommandParams: ICommandParams<ClearBrowserCookiesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.ClearBrowserCookies;
	}
}
