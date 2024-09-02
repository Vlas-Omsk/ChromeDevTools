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
	public class GetEncodedResponseCommandResult : ICommandResult
	{
		/// <summary>
		/// The encoded body as a base64 string. Omitted if sizeOnly is true. (Encoded as a base64 string when passed over JSON)
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Body { get; set; }
		/// <summary>
		/// Size before re-encoding.
		/// </summary>
		public long OriginalSize { get; set; }
		/// <summary>
		/// Size after re-encoding.
		/// </summary>
		public long EncodedSize { get; set; }
	}
}
