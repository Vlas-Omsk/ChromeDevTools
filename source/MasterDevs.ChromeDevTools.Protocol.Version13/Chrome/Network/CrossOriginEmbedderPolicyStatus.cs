using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	[SupportedBy("Chrome")]
	public class CrossOriginEmbedderPolicyStatus
	{
		/// <summary>
		/// Value
		/// </summary>
		public CrossOriginEmbedderPolicyValue Value { get; set; }
		/// <summary>
		/// ReportOnlyValue
		/// </summary>
		public CrossOriginEmbedderPolicyValue ReportOnlyValue { get; set; }
		/// <summary>
		/// ReportingEndpoint
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ReportingEndpoint { get; set; }
		/// <summary>
		/// ReportOnlyReportingEndpoint
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ReportOnlyReportingEndpoint { get; set; }
	}
}
