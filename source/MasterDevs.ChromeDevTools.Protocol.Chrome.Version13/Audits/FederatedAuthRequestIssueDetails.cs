using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Audits
{
	[SupportedBy("Chrome")]
	public class FederatedAuthRequestIssueDetails
	{
		/// <summary>
		/// FederatedAuthRequestIssueReason
		/// </summary>
		public FederatedAuthRequestIssueReason FederatedAuthRequestIssueReason { get; set; }
	}
}
