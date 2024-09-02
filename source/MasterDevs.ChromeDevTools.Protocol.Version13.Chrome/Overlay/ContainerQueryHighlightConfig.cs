using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Overlay
{
	[SupportedBy("Chrome")]
	public class ContainerQueryHighlightConfig
	{
		/// <summary>
		/// A descriptor for the highlight appearance of container query containers.
		/// </summary>
		public ContainerQueryContainerHighlightConfig ContainerQueryContainerHighlightConfig { get; set; }
		/// <summary>
		/// Identifier of the container node to highlight.
		/// </summary>
		public long NodeId { get; set; }
	}
}
