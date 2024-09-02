using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Fetch
{
	/// <summary>
	/// Issued when the domain is enabled with handleAuthRequests set to true.
	/// The request is paused until client responds with continueWithAuth.
	/// </summary>
	[EventName(ProtocolName.Fetch.AuthRequired)]
	[SupportedBy("Chrome")]
	public class AuthRequiredEventParams : IEventParams
	{
		/// <summary>
		/// Each request the page makes will have a unique id.
		/// </summary>
		public string RequestId { get; set; }
		/// <summary>
		/// The details of the request.
		/// </summary>
		public Network.Request Request { get; set; }
		/// <summary>
		/// The id of the frame that initiated the request.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// How the requested resource will be used.
		/// </summary>
		public Network.ResourceType ResourceType { get; set; }
		/// <summary>
		/// Details of the Authorization Challenge encountered.
		/// If this is set, client should respond with continueRequest that
		/// contains AuthChallengeResponse.
		/// </summary>
		public AuthChallenge AuthChallenge { get; set; }
	}
}
