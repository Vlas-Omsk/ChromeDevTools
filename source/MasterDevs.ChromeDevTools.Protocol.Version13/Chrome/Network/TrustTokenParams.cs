using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Determines what type of Trust Token operation is executed and
	/// depending on the type, some additional parameters. The values
	/// are specified in third_party/blink/renderer/core/fetch/trust_token.idl.
	/// </summary>
	[SupportedBy("Chrome")]
	public class TrustTokenParams
	{
		/// <summary>
		/// Operation
		/// </summary>
		public TrustTokenOperationType Operation { get; set; }
		/// <summary>
		/// Only set for "token-redemption" operation and determine whether
		/// to request a fresh SRR or use a still valid cached SRR.
		/// </summary>
		public string RefreshPolicy { get; set; }
		/// <summary>
		/// Origins of issuers from whom to request tokens or redemption
		/// records.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] Issuers { get; set; }
	}
}
