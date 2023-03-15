using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits
{
	/// <summary>
	/// This struct holds a list of optional fields with additional information
	/// specific to the kind of issue. When adding a new issue code, please also
	/// add a new optional field to this type.
	/// </summary>
	[SupportedBy("Chrome")]
	public class InspectorIssueDetails
	{
		/// <summary>
		/// CookieIssueDetails
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CookieIssueDetails CookieIssueDetails { get; set; }
		/// <summary>
		/// MixedContentIssueDetails
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public MixedContentIssueDetails MixedContentIssueDetails { get; set; }
		/// <summary>
		/// BlockedByResponseIssueDetails
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public BlockedByResponseIssueDetails BlockedByResponseIssueDetails { get; set; }
		/// <summary>
		/// HeavyAdIssueDetails
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public HeavyAdIssueDetails HeavyAdIssueDetails { get; set; }
		/// <summary>
		/// ContentSecurityPolicyIssueDetails
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ContentSecurityPolicyIssueDetails ContentSecurityPolicyIssueDetails { get; set; }
		/// <summary>
		/// SharedArrayBufferIssueDetails
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public SharedArrayBufferIssueDetails SharedArrayBufferIssueDetails { get; set; }
		/// <summary>
		/// TwaQualityEnforcementDetails
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public TrustedWebActivityIssueDetails TwaQualityEnforcementDetails { get; set; }
		/// <summary>
		/// LowTextContrastIssueDetails
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public LowTextContrastIssueDetails LowTextContrastIssueDetails { get; set; }
		/// <summary>
		/// CorsIssueDetails
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CorsIssueDetails CorsIssueDetails { get; set; }
		/// <summary>
		/// AttributionReportingIssueDetails
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AttributionReportingIssueDetails AttributionReportingIssueDetails { get; set; }
		/// <summary>
		/// QuirksModeIssueDetails
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public QuirksModeIssueDetails QuirksModeIssueDetails { get; set; }
		/// <summary>
		/// NavigatorUserAgentIssueDetails
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public NavigatorUserAgentIssueDetails NavigatorUserAgentIssueDetails { get; set; }
		/// <summary>
		/// GenericIssueDetails
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public GenericIssueDetails GenericIssueDetails { get; set; }
		/// <summary>
		/// DeprecationIssueDetails
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DeprecationIssueDetails DeprecationIssueDetails { get; set; }
		/// <summary>
		/// ClientHintIssueDetails
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ClientHintIssueDetails ClientHintIssueDetails { get; set; }
		/// <summary>
		/// FederatedAuthRequestIssueDetails
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public FederatedAuthRequestIssueDetails FederatedAuthRequestIssueDetails { get; set; }
	}
}
