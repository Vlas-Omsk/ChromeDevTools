using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Target
{
	[SupportedBy("Chrome")]
	public class TargetInfo
	{
		/// <summary>
		/// TargetId
		/// </summary>
		public string TargetId { get; set; }
		/// <summary>
		/// Type
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Title
		/// </summary>
		public string Title { get; set; }
		/// <summary>
		/// Url
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Whether the target has an attached client.
		/// </summary>
		public bool Attached { get; set; }
		/// <summary>
		/// Opener target Id
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string OpenerId { get; set; }
		/// <summary>
		/// Whether the target has access to the originating window.
		/// </summary>
		public bool CanAccessOpener { get; set; }
		/// <summary>
		/// Frame id of originating window (is only set if target has an opener).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string OpenerFrameId { get; set; }
		/// <summary>
		/// BrowserContextId
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string BrowserContextId { get; set; }
		/// <summary>
		/// Provides additional details for specific target types. For example, for
		/// the type of "page", this may be set to "portal" or "prerender".
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Subtype { get; set; }
	}
}
