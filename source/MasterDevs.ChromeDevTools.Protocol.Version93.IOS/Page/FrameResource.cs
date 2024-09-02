using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Page
{
	[SupportedBy("IOS")]
	public class FrameResource
	{
		/// <summary>
		/// Resource URL.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Type of this resource.
		/// </summary>
		public ResourceType Type { get; set; }
		/// <summary>
		/// Resource mimeType as determined by the browser.
		/// </summary>
		public string MimeType { get; set; }
		/// <summary>
		/// True if the resource failed to load.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Failed { get; set; }
		/// <summary>
		/// True if the resource was canceled during loading.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Canceled { get; set; }
		/// <summary>
		/// URL of source map associated with this resource (if any).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string SourceMapURL { get; set; }
	}
}
