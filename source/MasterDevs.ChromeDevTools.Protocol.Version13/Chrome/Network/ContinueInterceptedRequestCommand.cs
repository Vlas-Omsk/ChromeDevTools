using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Response to Network.requestIntercepted which either modifies the request to continue with any
	/// modifications, or blocks it, or completes it with the provided response bytes. If a network
	/// fetch occurs as a result which encounters a redirect an additional Network.requestIntercepted
	/// event will be sent with the same InterceptionId.
	/// Deprecated, use Fetch.continueRequest, Fetch.fulfillRequest and Fetch.failRequest instead.
	/// </summary>
	[Obsolete]
	[Command(ProtocolName.Network.ContinueInterceptedRequest)]
	[SupportedBy("Chrome")]
	public class ContinueInterceptedRequestCommand: IProtocolCommand<ContinueInterceptedRequestCommandResponse>
	{
		/// <summary>
		/// InterceptionId
		/// </summary>
		public string InterceptionId { get; set; }
		/// <summary>
		/// If set this causes the request to fail with the given reason. Passing `Aborted` for requests
		/// marked with `isNavigationRequest` also cancels the navigation. Must not be set in response
		/// to an authChallenge.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ErrorReason { get; set; }
		/// <summary>
		/// If set the requests completes using with the provided base64 encoded raw response, including
		/// HTTP status line and headers etc... Must not be set in response to an authChallenge. (Encoded as a base64 string when passed over JSON)
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string RawResponse { get; set; }
		/// <summary>
		/// If set the request url will be modified in a way that's not observable by page. Must not be
		/// set in response to an authChallenge.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Url { get; set; }
		/// <summary>
		/// If set this allows the request method to be overridden. Must not be set in response to an
		/// authChallenge.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Method { get; set; }
		/// <summary>
		/// If set this allows postData to be set. Must not be set in response to an authChallenge.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string PostData { get; set; }
		/// <summary>
		/// If set this allows the request headers to be changed. Must not be set in response to an
		/// authChallenge.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Dictionary<string, string> Headers { get; set; }
		/// <summary>
		/// Response to a requestIntercepted with an authChallenge. Must not be set otherwise.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AuthChallengeResponse AuthChallengeResponse { get; set; }
	}
}
