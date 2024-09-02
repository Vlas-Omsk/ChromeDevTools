using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Audits
{
	/// <summary>
	/// Depending on the concrete errorType, different properties are set.
	/// </summary>
	[SupportedBy("Chrome")]
	public class GenericIssueDetails
	{
		/// <summary>
		/// Issues with the same errorType are aggregated in the frontend.
		/// </summary>
		public GenericIssueErrorType ErrorType { get; set; }
		/// <summary>
		/// FrameId
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string FrameId { get; set; }
		/// <summary>
		/// ViolatingNodeId
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ViolatingNodeId { get; set; }
	}
}
