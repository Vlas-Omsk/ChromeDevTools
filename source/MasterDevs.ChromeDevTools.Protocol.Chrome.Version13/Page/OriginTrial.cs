using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page
{
	[SupportedBy("Chrome")]
	public class OriginTrial
	{
		/// <summary>
		/// TrialName
		/// </summary>
		public string TrialName { get; set; }
		/// <summary>
		/// Status
		/// </summary>
		public OriginTrialStatus Status { get; set; }
		/// <summary>
		/// TokensWithStatus
		/// </summary>
		public OriginTrialTokenWithStatus[] TokensWithStatus { get; set; }
	}
}
