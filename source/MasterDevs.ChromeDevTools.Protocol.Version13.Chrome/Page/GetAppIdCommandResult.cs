using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Returns the unique (PWA) app id.
	/// Only returns values if the feature flag 'WebAppEnableManifestId' is enabled
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetAppIdCommandResult : ICommandResult
	{
		/// <summary>
		/// App id, either from manifest's id attribute or computed from start_url
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string AppId { get; set; }
		/// <summary>
		/// Recommendation for manifest's id attribute to match current id computed from start_url
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string RecommendedId { get; set; }
	}
}
