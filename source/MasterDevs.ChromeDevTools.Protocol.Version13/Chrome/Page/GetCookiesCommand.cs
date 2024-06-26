using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Returns all browser cookies for the page and all of its subframes. Depending
	/// on the backend support, will return detailed cookie information in the
	/// `cookies` field.
	/// </summary>
	[Obsolete]
	[Command(ProtocolName.Page.GetCookies)]
	[SupportedBy("Chrome")]
	public class GetCookiesCommand: IProtocolCommand<GetCookiesCommandResponse>
	{
	}
}
