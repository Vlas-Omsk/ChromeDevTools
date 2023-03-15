using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// CSS Layer data.
	/// </summary>
	[SupportedBy("Chrome")]
	public class CSSLayerData
	{
		/// <summary>
		/// Layer name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Direct sub-layers
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CSSLayerData[] SubLayers { get; set; }
		/// <summary>
		/// Layer order. The order determines the order of the layer in the cascade order.
		/// A higher number has higher priority in the cascade order.
		/// </summary>
		public double Order { get; set; }
	}
}
