using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Overlay
{
	[SupportedBy("Chrome")]
	public class ScrollSnapHighlightConfig
	{
		/// <summary>
		/// A descriptor for the highlight appearance of scroll snap containers.
		/// </summary>
		public ScrollSnapContainerHighlightConfig ScrollSnapContainerHighlightConfig { get; set; }
		/// <summary>
		/// Identifier of the node to highlight.
		/// </summary>
		public long NodeId { get; set; }
	}
}
