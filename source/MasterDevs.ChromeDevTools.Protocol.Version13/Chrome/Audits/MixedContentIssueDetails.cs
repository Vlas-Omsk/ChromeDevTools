using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits
{
	[SupportedBy("Chrome")]
	public class MixedContentIssueDetails
	{
		/// <summary>
		/// The type of resource causing the mixed content issue (css, js, iframe,
		/// form,...). Marked as optional because it is mapped to from
		/// blink::mojom::RequestContextType, which will be replaced
		/// by network::mojom::RequestDestination
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public MixedContentResourceType ResourceType { get; set; }
		/// <summary>
		/// The way the mixed content issue is being resolved.
		/// </summary>
		public MixedContentResolutionStatus ResolutionStatus { get; set; }
		/// <summary>
		/// The unsafe http url causing the mixed content issue.
		/// </summary>
		public string InsecureURL { get; set; }
		/// <summary>
		/// The url responsible for the call to an unsafe url.
		/// </summary>
		public string MainResourceURL { get; set; }
		/// <summary>
		/// The mixed content request.
		/// Does not always exist (e.g. for unsafe form submission urls).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AffectedRequest Request { get; set; }
		/// <summary>
		/// Optional because not every mixed content issue is necessarily linked to a frame.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AffectedFrame Frame { get; set; }
	}
}
