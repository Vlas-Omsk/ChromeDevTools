using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Information about the request initiator.
	/// </summary>
	[SupportedBy("Chrome")]
	public class Initiator
	{
		/// <summary>
		/// Type of this initiator.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Initiator JavaScript stack trace, set for Script only.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Runtime.StackTrace Stack { get; set; }
		/// <summary>
		/// Initiator URL, set for Parser type or for Script type (when script is importing module) or for SignedExchange type.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Url { get; set; }
		/// <summary>
		/// Initiator line number, set for Parser type or for Script type (when script is importing
		/// module) (0-based).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double LineNumber { get; set; }
		/// <summary>
		/// Initiator column number, set for Parser type or for Script type (when script is importing
		/// module) (0-based).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double ColumnNumber { get; set; }
		/// <summary>
		/// Set if another request triggered this request (e.g. preflight).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string RequestId { get; set; }
	}
}
