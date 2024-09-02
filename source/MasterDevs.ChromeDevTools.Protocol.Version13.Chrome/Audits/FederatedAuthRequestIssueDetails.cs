using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Audits
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
