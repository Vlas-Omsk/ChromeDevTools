using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Security
{
	/// <summary>
	/// Security state information about the page.
	/// </summary>
	[SupportedBy("Chrome")]
	public class VisibleSecurityState
	{
		/// <summary>
		/// The security level of the page.
		/// </summary>
		public SecurityState SecurityState { get; set; }
		/// <summary>
		/// Security state details about the page certificate.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CertificateSecurityState CertificateSecurityState { get; set; }
		/// <summary>
		/// The type of Safety Tip triggered on the page. Note that this field will be set even if the Safety Tip UI was not actually shown.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public SafetyTipInfo SafetyTipInfo { get; set; }
		/// <summary>
		/// Array of security state issues ids.
		/// </summary>
		public string[] SecurityStateIssueIds { get; set; }
	}
}
