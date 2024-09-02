using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Audits
{
	[SupportedBy("Chrome")]
	public class ContentSecurityPolicyIssueDetails
	{
		/// <summary>
		/// The url not included in allowed sources.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string BlockedURL { get; set; }
		/// <summary>
		/// Specific directive that is violated, causing the CSP issue.
		/// </summary>
		public string ViolatedDirective { get; set; }
		/// <summary>
		/// IsReportOnly
		/// </summary>
		public bool IsReportOnly { get; set; }
		/// <summary>
		/// ContentSecurityPolicyViolationType
		/// </summary>
		public ContentSecurityPolicyViolationType ContentSecurityPolicyViolationType { get; set; }
		/// <summary>
		/// FrameAncestor
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AffectedFrame FrameAncestor { get; set; }
		/// <summary>
		/// SourceCodeLocation
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public SourceCodeLocation SourceCodeLocation { get; set; }
		/// <summary>
		/// ViolatingNodeId
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ViolatingNodeId { get; set; }
	}
}
