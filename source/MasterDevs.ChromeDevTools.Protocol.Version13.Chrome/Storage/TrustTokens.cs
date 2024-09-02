using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Storage
{
	/// <summary>
	/// Pair of issuer origin and number of available (signed, but not used) Trust
	/// Tokens from that issuer.
	/// </summary>
	[SupportedBy("Chrome")]
	public class TrustTokens
	{
		/// <summary>
		/// IssuerOrigin
		/// </summary>
		public string IssuerOrigin { get; set; }
		/// <summary>
		/// Count
		/// </summary>
		public double Count { get; set; }
	}
}
