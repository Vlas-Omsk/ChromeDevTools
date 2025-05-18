using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page
{
	[SupportedBy("Chrome")]
	public class OriginTrialTokenWithStatus
	{
		/// <summary>
		/// RawTokenText
		/// </summary>
		public string RawTokenText { get; set; }
		/// <summary>
		/// `parsedToken` is present only when the token is extractable and
		/// parsable.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public OriginTrialToken ParsedToken { get; set; }
		/// <summary>
		/// Status
		/// </summary>
		public OriginTrialTokenStatus Status { get; set; }
	}
}
