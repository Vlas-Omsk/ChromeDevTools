using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Fetch
{
	/// <summary>
	/// Continues a request supplying authChallengeResponse following authRequired event.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ContinueWithAuthCommand: ICommand<ContinueWithAuthCommandResult>
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
