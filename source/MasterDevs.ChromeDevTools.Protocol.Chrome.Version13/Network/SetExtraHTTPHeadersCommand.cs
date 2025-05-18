using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Network
{
	/// <summary>
	/// Specifies whether to always send extra HTTP headers with the requests from this page.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetExtraHTTPHeadersCommand: ICommand<SetExtraHTTPHeadersCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.SetExtraHTTPHeaders;
		/// <summary>
		/// Map with extra HTTP headers.
		/// </summary>
		public Dictionary<string, string> Headers { get; set; }
	}
}
