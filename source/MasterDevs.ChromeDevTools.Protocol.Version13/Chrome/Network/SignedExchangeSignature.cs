using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Information about a signed exchange signature.
	/// https://wicg.github.io/webpackage/draft-yasskin-httpbis-origin-signed-exchanges-impl.html#rfc.section.3.1
	/// </summary>
	[SupportedBy("Chrome")]
	public class SignedExchangeSignature
	{
		/// <summary>
		/// Signed exchange signature label.
		/// </summary>
		public string Label { get; set; }
		/// <summary>
		/// The hex string of signed exchange signature.
		/// </summary>
		public string Signature { get; set; }
		/// <summary>
		/// Signed exchange signature integrity.
		/// </summary>
		public string Integrity { get; set; }
		/// <summary>
		/// Signed exchange signature cert Url.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string CertUrl { get; set; }
		/// <summary>
		/// The hex string of signed exchange signature cert sha256.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string CertSha256 { get; set; }
		/// <summary>
		/// Signed exchange signature validity Url.
		/// </summary>
		public string ValidityUrl { get; set; }
		/// <summary>
		/// Signed exchange signature date.
		/// </summary>
		public long Date { get; set; }
		/// <summary>
		/// Signed exchange signature expires.
		/// </summary>
		public long Expires { get; set; }
		/// <summary>
		/// The encoded certificates.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] Certificates { get; set; }
	}
}
