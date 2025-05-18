using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Storage
{
	/// <summary>
	/// Ad advertising element inside an interest group.
	/// </summary>
	[SupportedBy("Chrome")]
	public class InterestGroupAd
	{
		/// <summary>
		/// RenderUrl
		/// </summary>
		public string RenderUrl { get; set; }
		/// <summary>
		/// Metadata
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Metadata { get; set; }
	}
}
