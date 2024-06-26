using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Fired for failed bfcache history navigations if BackForwardCache feature is enabled. Do
	/// not assume any ordering with the Page.frameNavigated event. This event is fired only for
	/// main-frame history navigation where the document changes (non-same-document navigations),
	/// when bfcache navigation fails.
	/// </summary>
	[Event(ProtocolName.Page.BackForwardCacheNotUsed)]
	[SupportedBy("Chrome")]
	public class BackForwardCacheNotUsedEvent
	{
		/// <summary>
		/// The loader id for the associated navgation.
		/// </summary>
		public string LoaderId { get; set; }
		/// <summary>
		/// The frame id of the associated frame.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Array of reasons why the page could not be cached. This must not be empty.
		/// </summary>
		public BackForwardCacheNotRestoredExplanation[] NotRestoredExplanations { get; set; }
		/// <summary>
		/// Tree structure of reasons why the page could not be cached for each frame.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public BackForwardCacheNotRestoredExplanationTree NotRestoredExplanationsTree { get; set; }
	}
}
