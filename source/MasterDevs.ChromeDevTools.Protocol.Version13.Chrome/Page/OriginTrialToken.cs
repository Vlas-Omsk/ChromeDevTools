using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	[SupportedBy("Chrome")]
	public class OriginTrialToken
	{
		/// <summary>
		/// Origin
		/// </summary>
		public string Origin { get; set; }
		/// <summary>
		/// MatchSubDomains
		/// </summary>
		public bool MatchSubDomains { get; set; }
		/// <summary>
		/// TrialName
		/// </summary>
		public string TrialName { get; set; }
		/// <summary>
		/// ExpiryTime
		/// </summary>
		public double ExpiryTime { get; set; }
		/// <summary>
		/// IsThirdParty
		/// </summary>
		public bool IsThirdParty { get; set; }
		/// <summary>
		/// UsageRestriction
		/// </summary>
		public OriginTrialUsageRestriction UsageRestriction { get; set; }
	}
}
