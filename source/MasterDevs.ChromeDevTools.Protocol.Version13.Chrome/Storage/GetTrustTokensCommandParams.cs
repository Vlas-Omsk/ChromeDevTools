using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Storage
{
	/// <summary>
	/// Returns the number of stored Trust Tokens per issuer for the
	/// current browsing context.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetTrustTokensCommandParams: ICommandParams<GetTrustTokensCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Storage.GetTrustTokens;
	}
}
