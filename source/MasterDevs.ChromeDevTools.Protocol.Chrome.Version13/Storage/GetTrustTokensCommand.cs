using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Storage
{
	/// <summary>
	/// Returns the number of stored Trust Tokens per issuer for the
	/// current browsing context.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetTrustTokensCommand: ICommand<GetTrustTokensCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Storage.GetTrustTokens;
	}
}
