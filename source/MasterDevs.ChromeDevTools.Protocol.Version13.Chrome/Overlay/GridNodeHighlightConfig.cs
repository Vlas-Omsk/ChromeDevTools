using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Overlay
{
	/// <summary>
	/// Configurations for Persistent Grid Highlight
	/// </summary>
	[SupportedBy("Chrome")]
	public class GridNodeHighlightConfig
	{
		/// <summary>
		/// A descriptor for the highlight appearance.
		/// </summary>
		public GridHighlightConfig GridHighlightConfig { get; set; }
		/// <summary>
		/// Identifier of the node to highlight.
		/// </summary>
		public long NodeId { get; set; }
	}
}
