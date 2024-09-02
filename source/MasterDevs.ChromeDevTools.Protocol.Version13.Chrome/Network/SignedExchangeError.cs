using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Information about a signed exchange response.
	/// </summary>
	[SupportedBy("Chrome")]
	public class SignedExchangeError
	{
		/// <summary>
		/// Error message.
		/// </summary>
		public string Message { get; set; }
		/// <summary>
		/// The index of the signature which caused the error.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? SignatureIndex { get; set; }
		/// <summary>
		/// The field which caused the error.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public SignedExchangeErrorField ErrorField { get; set; }
	}
}
