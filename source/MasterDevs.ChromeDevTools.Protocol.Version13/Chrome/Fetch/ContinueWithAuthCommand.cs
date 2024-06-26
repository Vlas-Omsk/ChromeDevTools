using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Fetch
{
	/// <summary>
	/// Continues a request supplying authChallengeResponse following authRequired event.
	/// </summary>
	[Command(ProtocolName.Fetch.ContinueWithAuth)]
	[SupportedBy("Chrome")]
	public class ContinueWithAuthCommand: IProtocolCommand<ContinueWithAuthCommandResponse>
	{
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
