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
	public class ClearTrustTokensCommandResult : ICommandResult
	{
		/// <summary>
		/// True if any tokens were deleted, false otherwise.
		/// </summary>
		public bool DidDeleteTokens { get; set; }
	}
}
