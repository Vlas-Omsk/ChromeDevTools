using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Details of a signed certificate timestamp (SCT).
	/// </summary>
	[SupportedBy("Chrome")]
	public class SignedCertificateTimestamp
	{
		/// <summary>
		/// Validation status.
		/// </summary>
		public string Status { get; set; }
		/// <summary>
		/// Origin.
		/// </summary>
		public string Origin { get; set; }
		/// <summary>
		/// Log name / description.
		/// </summary>
		public string LogDescription { get; set; }
		/// <summary>
		/// Log ID.
		/// </summary>
		public string LogId { get; set; }
		/// <summary>
		/// Issuance date. Unlike TimeSinceEpoch, this contains the number of
		/// milliseconds since January 1, 1970, UTC, not the number of seconds.
		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// Hash algorithm.
		/// </summary>
		public string HashAlgorithm { get; set; }
		/// <summary>
		/// Signature algorithm.
		/// </summary>
		public string SignatureAlgorithm { get; set; }
		/// <summary>
		/// Signature data.
		/// </summary>
		public string SignatureData { get; set; }
	}
}
