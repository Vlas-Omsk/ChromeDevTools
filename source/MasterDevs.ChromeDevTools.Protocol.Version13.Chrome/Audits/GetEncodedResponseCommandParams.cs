using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Audits
{
	/// <summary>
	/// Returns the response body and size if it were re-encoded with the specified settings. Only
	/// applies to images.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetEncodedResponseCommandParams: ICommandParams<GetEncodedResponseCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Audits.GetEncodedResponse;
		/// <summary>
		/// Identifier of the network request to get content for.
		/// </summary>
		public string RequestId { get; set; }
		/// <summary>
		/// The encoding to use.
		/// </summary>
		public string Encoding { get; set; }
		/// <summary>
		/// The quality of the encoding (0-1). (defaults to 1)
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Quality { get; set; }
		/// <summary>
		/// Whether to only return the size information (defaults to false).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? SizeOnly { get; set; }
	}
}
