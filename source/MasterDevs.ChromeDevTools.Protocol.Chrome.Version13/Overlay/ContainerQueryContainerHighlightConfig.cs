using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Overlay
{
	[SupportedBy("Chrome")]
	public class ContainerQueryContainerHighlightConfig
	{
		/// <summary>
		/// The style of the container border.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public LineStyle ContainerBorder { get; set; }
		/// <summary>
		/// The style of the descendants' borders.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public LineStyle DescendantBorder { get; set; }
	}
}
