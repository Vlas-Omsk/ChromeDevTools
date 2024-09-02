using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Audits
{
	/// <summary>
	/// Details for a CORS related issue, e.g. a warning or error related to
	/// CORS RFC1918 enforcement.
	/// </summary>
	[SupportedBy("Chrome")]
	public class CorsIssueDetails
	{
		/// <summary>
		/// CorsErrorStatus
		/// </summary>
		public Network.CorsErrorStatus CorsErrorStatus { get; set; }
		/// <summary>
		/// IsWarning
		/// </summary>
		public bool IsWarning { get; set; }
		/// <summary>
		/// Request
		/// </summary>
		public AffectedRequest Request { get; set; }
		/// <summary>
		/// Location
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public SourceCodeLocation Location { get; set; }
		/// <summary>
		/// InitiatorOrigin
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string InitiatorOrigin { get; set; }
		/// <summary>
		/// ResourceIPAddressSpace
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Network.IPAddressSpace ResourceIPAddressSpace { get; set; }
		/// <summary>
		/// ClientSecurityState
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Network.ClientSecurityState ClientSecurityState { get; set; }
	}
}
