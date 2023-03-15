using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits
{
	[SupportedBy("Chrome")]
	public class HeavyAdIssueDetails
	{
		/// <summary>
		/// The resolution status, either blocking the content or warning.
		/// </summary>
		public HeavyAdResolutionStatus Resolution { get; set; }
		/// <summary>
		/// The reason the ad was blocked, total network or cpu or peak cpu.
		/// </summary>
		public HeavyAdReason Reason { get; set; }
		/// <summary>
		/// The frame that was blocked.
		/// </summary>
		public AffectedFrame Frame { get; set; }
	}
}
