using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Network
{
	/// <summary>
	/// Specifies whether to always send extra HTTP headers with the requests from this page.
	/// </summary>

	[SupportedBy("IOS")]
	public class SetExtraHTTPHeadersCommandParams: ICommandParams<SetExtraHTTPHeadersCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.SetExtraHTTPHeaders;
		/// <summary>
		/// Map with extra HTTP headers.
		/// </summary>
		public Dictionary<string, string> Headers { get; set; }
	}
}
