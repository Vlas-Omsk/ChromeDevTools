using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Fetch
{
	/// <summary>
	/// Provides response to the request.
	/// </summary>

	[SupportedBy("Chrome")]
	public class FulfillRequestCommandParams: ICommandParams<FulfillRequestCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Fetch.FulfillRequest;
		/// <summary>
		/// An id the client received in requestPaused event.
		/// </summary>
		public string RequestId { get; set; }
		/// <summary>
		/// An HTTP response code.
		/// </summary>
		public long ResponseCode { get; set; }
		/// <summary>
		/// Response headers.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public HeaderEntry[] ResponseHeaders { get; set; }
		/// <summary>
		/// Alternative way of specifying response headers as a \0-separated
		/// series of name: value pairs. Prefer the above method unless you
		/// need to represent some non-UTF8 values that can't be transmitted
		/// over the protocol as text. (Encoded as a base64 string when passed over JSON)
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string BinaryResponseHeaders { get; set; }
		/// <summary>
		/// A response body. If absent, original response body will be used if
		/// the request is intercepted at the response stage and empty body
		/// will be used if the request is intercepted at the request stage. (Encoded as a base64 string when passed over JSON)
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Body { get; set; }
		/// <summary>
		/// A textual representation of responseCode.
		/// If absent, a standard phrase matching responseCode is used.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ResponsePhrase { get; set; }
	}
}
