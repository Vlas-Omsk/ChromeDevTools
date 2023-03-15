using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits
{
	/// <summary>
	/// Details for a request that has been blocked with the BLOCKED_BY_RESPONSE
	/// code. Currently only used for COEP/COOP, but may be extended to include
	/// some CSP errors in the future.
	/// </summary>
	[SupportedBy("Chrome")]
	public class BlockedByResponseIssueDetails
	{
		/// <summary>
		/// Request
		/// </summary>
		public AffectedRequest Request { get; set; }
		/// <summary>
		/// ParentFrame
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AffectedFrame ParentFrame { get; set; }
		/// <summary>
		/// BlockedFrame
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AffectedFrame BlockedFrame { get; set; }
		/// <summary>
		/// Reason
		/// </summary>
		public BlockedByResponseReason Reason { get; set; }
	}
}
