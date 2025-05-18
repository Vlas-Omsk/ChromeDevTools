using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Page
{
	/// <summary>
	/// Returns all browser cookies. Depending on the backend support, will return detailed cookie information in the <code>cookies</code> field.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetCookiesCommand: ICommand<GetCookiesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.GetCookies;
	}
}
