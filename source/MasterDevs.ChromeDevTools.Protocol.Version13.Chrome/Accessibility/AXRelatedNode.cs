using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Accessibility
{
	[SupportedBy("Chrome")]
	public class AXRelatedNode
	{
		/// <summary>
		/// The BackendNodeId of the related DOM node.
		/// </summary>
		public long BackendDOMNodeId { get; set; }
		/// <summary>
		/// The IDRef value provided, if any.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Idref { get; set; }
		/// <summary>
		/// The text alternative of this node in the current context.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Text { get; set; }
	}
}