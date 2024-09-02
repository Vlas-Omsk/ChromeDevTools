using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// DOM interaction is implemented in terms of mirror objects that represent the actual DOM nodes.
	/// DOMNode is a base node mirror type.
	/// </summary>
	[SupportedBy("Chrome")]
	public class Node
	{
		/// <summary>
		/// Node identifier that is passed into the rest of the DOM messages as the `nodeId`. Backend
		/// will only push node with given `id` once. It is aware of all requested nodes and will only
		/// fire DOM events for nodes known to the client.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// The id of the parent node if any.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ParentId { get; set; }
		/// <summary>
		/// The BackendNodeId for this node.
		/// </summary>
		public long BackendNodeId { get; set; }
		/// <summary>
		/// `Node`'s nodeType.
		/// </summary>
		public long NodeType { get; set; }
		/// <summary>
		/// `Node`'s nodeName.
		/// </summary>
		public string NodeName { get; set; }
		/// <summary>
		/// `Node`'s localName.
		/// </summary>
		public string LocalName { get; set; }
		/// <summary>
		/// `Node`'s nodeValue.
		/// </summary>
		public string NodeValue { get; set; }
		/// <summary>
		/// Child count for `Container` nodes.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ChildNodeCount { get; set; }
		/// <summary>
		/// Child nodes of this node when requested with children.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Node[] Children { get; set; }
		/// <summary>
		/// Attributes of the `Element` node in the form of flat array `[name1, value1, name2, value2]`.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] Attributes { get; set; }
		/// <summary>
		/// Document URL that `Document` or `FrameOwner` node points to.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string DocumentURL { get; set; }
		/// <summary>
		/// Base URL that `Document` or `FrameOwner` node uses for URL completion.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string BaseURL { get; set; }
		/// <summary>
		/// `DocumentType`'s publicId.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string PublicId { get; set; }
		/// <summary>
		/// `DocumentType`'s systemId.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string SystemId { get; set; }
		/// <summary>
		/// `DocumentType`'s internalSubset.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string InternalSubset { get; set; }
		/// <summary>
		/// `Document`'s XML version in case of XML documents.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string XmlVersion { get; set; }
		/// <summary>
		/// `Attr`'s name.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Name { get; set; }
		/// <summary>
		/// `Attr`'s value.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Value { get; set; }
		/// <summary>
		/// Pseudo element type for this node.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public PseudoType PseudoType { get; set; }
		/// <summary>
		/// Pseudo element identifier for this node. Only present if there is a
		/// valid pseudoType.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string PseudoIdentifier { get; set; }
		/// <summary>
		/// Shadow root type.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ShadowRootType ShadowRootType { get; set; }
		/// <summary>
		/// Frame ID for frame owner elements.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string FrameId { get; set; }
		/// <summary>
		/// Content document for frame owner elements.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Node ContentDocument { get; set; }
		/// <summary>
		/// Shadow root list for given element host.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Node[] ShadowRoots { get; set; }
		/// <summary>
		/// Content document fragment for template elements.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Node TemplateContent { get; set; }
		/// <summary>
		/// Pseudo elements associated with this node.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Node[] PseudoElements { get; set; }
		/// <summary>
		/// Deprecated, as the HTML Imports API has been removed (crbug.com/937746).
		/// This property used to return the imported document for the HTMLImport links.
		/// The property is always undefined now.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Node ImportedDocument { get; set; }
		/// <summary>
		/// Distributed nodes for given insertion point.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public BackendNode[] DistributedNodes { get; set; }
		/// <summary>
		/// Whether the node is SVG.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IsSVG { get; set; }
		/// <summary>
		/// CompatibilityMode
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CompatibilityMode CompatibilityMode { get; set; }
		/// <summary>
		/// AssignedSlot
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public BackendNode AssignedSlot { get; set; }
	}
}
