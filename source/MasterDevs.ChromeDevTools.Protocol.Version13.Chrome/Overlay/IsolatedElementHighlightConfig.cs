using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Overlay
{
	[SupportedBy("Chrome")]
	public class IsolatedElementHighlightConfig
	{
		/// <summary>
		/// A descriptor for the highlight appearance of an element in isolation mode.
		/// </summary>
		public IsolationModeHighlightConfig IsolationModeHighlightConfig { get; set; }
		/// <summary>
		/// Identifier of the isolated element to highlight.
		/// </summary>
		public long NodeId { get; set; }
	}
}
