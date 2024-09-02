using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Returns all browser cookies. Depending on the backend support, will return detailed cookie
	/// information in the `cookies` field.
	/// Deprecated. Use Storage.getCookies instead.
	/// </summary>
	[Obsolete]

	[SupportedBy("Chrome")]
	public class GetAllCookiesCommandParams: ICommandParams<GetAllCookiesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.GetAllCookies;
	}
}
