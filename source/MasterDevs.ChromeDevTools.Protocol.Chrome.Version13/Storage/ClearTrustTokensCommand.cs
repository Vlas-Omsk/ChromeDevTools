using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Storage
{
	/// <summary>
	/// Removes all Trust Tokens issued by the provided issuerOrigin.
	/// Leaves other stored data, including the issuer's Redemption Records, intact.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ClearTrustTokensCommand: ICommand<ClearTrustTokensCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Storage.ClearTrustTokens;
		/// <summary>
		/// IssuerOrigin
		/// </summary>
		public string IssuerOrigin { get; set; }
	}
}
