using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Accessibility
{
	/// <summary>
	/// A single computed AX property.
	/// </summary>
	[SupportedBy("Chrome")]
	public class AXValue
	{
		/// <summary>
		/// The type of this value.
		/// </summary>
		public AXValueType Type { get; set; }
		/// <summary>
		/// The computed value of this property.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public object Value { get; set; }
		/// <summary>
		/// One or more related nodes, if applicable.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AXRelatedNode[] RelatedNodes { get; set; }
		/// <summary>
		/// The sources which contributed to the computation of this property.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AXValueSource[] Sources { get; set; }
	}
}
