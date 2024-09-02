using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Storage
{
	/// <summary>
	/// Removes all Trust Tokens issued by the provided issuerOrigin.
	/// Leaves other stored data, including the issuer's Redemption Records, intact.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ClearTrustTokensCommandParams: ICommandParams<ClearTrustTokensCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Storage.ClearTrustTokens;
		/// <summary>
		/// IssuerOrigin
		/// </summary>
		public string IssuerOrigin { get; set; }
	}
}
