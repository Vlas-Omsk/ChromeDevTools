using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
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
