using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Returns all browser cookies. Depending on the backend support, will return detailed cookie
	/// information in the `cookies` field.
	/// Deprecated. Use Storage.getCookies instead.
	/// </summary>
	[Obsolete]
	[Command(ProtocolName.Network.GetAllCookies)]
	[SupportedBy("Chrome")]
	public class GetAllCookiesCommand: ICommandParams<GetAllCookiesCommandResponse>
	{
	}
}
