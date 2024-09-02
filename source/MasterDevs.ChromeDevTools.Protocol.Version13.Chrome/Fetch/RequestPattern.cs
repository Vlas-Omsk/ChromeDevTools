using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Fetch
{
	[SupportedBy("Chrome")]
	public class RequestPattern
	{
		/// <summary>
		/// Wildcards (`'*'` -> zero or more, `'?'` -> exactly one) are allowed. Escape character is
		/// backslash. Omitting is equivalent to `"*"`.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string UrlPattern { get; set; }
		/// <summary>
		/// If set, only requests for matching resource types will be intercepted.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Network.ResourceType ResourceType { get; set; }
		/// <summary>
		/// Stage at which to begin intercepting requests. Default is Request.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RequestStage RequestStage { get; set; }
	}
}
