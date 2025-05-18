using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Network
{
	/// <summary>
	/// Returns all browser cookies. Depending on the backend support, will return detailed cookie
	/// information in the `cookies` field.
	/// Deprecated. Use Storage.getCookies instead.
	/// </summary>
	[Obsolete]

	[SupportedBy("Chrome")]
	public class GetAllCookiesCommand: ICommand<GetAllCookiesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.GetAllCookies;
	}
}
