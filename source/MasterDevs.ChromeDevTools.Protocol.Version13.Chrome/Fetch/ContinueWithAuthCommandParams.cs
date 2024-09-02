using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Fetch
{
	/// <summary>
	/// Continues a request supplying authChallengeResponse following authRequired event.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ContinueWithAuthCommandParams: ICommandParams<ContinueWithAuthCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Fetch.ContinueWithAuth;
		/// <summary>
		/// An id the client received in authRequired event.
		/// </summary>
		public string RequestId { get; set; }
		/// <summary>
		/// Response to  with an authChallenge.
		/// </summary>
		public AuthChallengeResponse AuthChallengeResponse { get; set; }
	}
}
