using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Accessibility
{
	/// <summary>
	/// A node in the accessibility tree.
	/// </summary>
	[SupportedBy("Chrome")]
	public class AXNode
	{
		/// <summary>
		/// Unique identifier for this node.
		/// </summary>
		public string NodeId { get; set; }
		/// <summary>
		/// Whether this node is ignored for accessibility
		/// </summary>
		public bool Ignored { get; set; }
		/// <summary>
		/// Collection of reasons why this node is hidden.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AXProperty[] IgnoredReasons { get; set; }
		/// <summary>
		/// This `Node`'s role, whether explicit or implicit.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AXValue Role { get; set; }
		/// <summary>
		/// This `Node`'s Chrome raw role.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AXValue ChromeRole { get; set; }
		/// <summary>
		/// The accessible name for this `Node`.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AXValue Name { get; set; }
		/// <summary>
		/// The accessible description for this `Node`.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AXValue Description { get; set; }
		/// <summary>
		/// The value for this `Node`.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AXValue Value { get; set; }
		/// <summary>
		/// All other properties
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AXProperty[] Properties { get; set; }
		/// <summary>
		/// ID for this node's parent.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ParentId { get; set; }
		/// <summary>
		/// IDs for each of this node's child nodes.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] ChildIds { get; set; }
		/// <summary>
		/// The backend ID for the associated DOM node, if any.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? BackendDOMNodeId { get; set; }
		/// <summary>
		/// The frame ID for the frame associated with this nodes document.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string FrameId { get; set; }
	}
}
