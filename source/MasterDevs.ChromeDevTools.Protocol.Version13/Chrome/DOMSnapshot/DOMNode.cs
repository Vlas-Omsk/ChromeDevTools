using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMSnapshot
{
	/// <summary>
	/// A Node in the DOM tree.
	/// </summary>
	[SupportedBy("Chrome")]
	public class DOMNode
	{
		/// <summary>
		/// `Node`'s nodeType.
		/// </summary>
		public long NodeType { get; set; }
		/// <summary>
		/// `Node`'s nodeName.
		/// </summary>
		public string NodeName { get; set; }
		/// <summary>
		/// `Node`'s nodeValue.
		/// </summary>
		public string NodeValue { get; set; }
		/// <summary>
		/// Only set for textarea elements, contains the text value.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string TextValue { get; set; }
		/// <summary>
		/// Only set for input elements, contains the input's associated text value.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string InputValue { get; set; }
		/// <summary>
		/// Only set for radio and checkbox input elements, indicates if the element has been checked
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? InputChecked { get; set; }
		/// <summary>
		/// Only set for option elements, indicates if the element has been selected
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? OptionSelected { get; set; }
		/// <summary>
		/// `Node`'s id, corresponds to DOM.Node.backendNodeId.
		/// </summary>
		public long BackendNodeId { get; set; }
		/// <summary>
		/// The indexes of the node's child nodes in the `domNodes` array returned by `getSnapshot`, if
		/// any.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long[] ChildNodeIndexes { get; set; }
		/// <summary>
		/// Attributes of an `Element` node.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public NameValue[] Attributes { get; set; }
		/// <summary>
		/// Indexes of pseudo elements associated with this node in the `domNodes` array returned by
		/// `getSnapshot`, if any.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long[] PseudoElementIndexes { get; set; }
		/// <summary>
		/// The index of the node's related layout tree node in the `layoutTreeNodes` array returned by
		/// `getSnapshot`, if any.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? LayoutNodeIndex { get; set; }
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
		/// Only set for documents, contains the document's content language.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ContentLanguage { get; set; }
		/// <summary>
		/// Only set for documents, contains the document's character set encoding.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string DocumentEncoding { get; set; }
		/// <summary>
		/// `DocumentType` node's publicId.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string PublicId { get; set; }
		/// <summary>
		/// `DocumentType` node's systemId.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string SystemId { get; set; }
		/// <summary>
		/// Frame ID for frame owner elements and also for the document node.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string FrameId { get; set; }
		/// <summary>
		/// The index of a frame owner element's content document in the `domNodes` array returned by
		/// `getSnapshot`, if any.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ContentDocumentIndex { get; set; }
		/// <summary>
		/// Type of a pseudo element node.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.PseudoType PseudoType { get; set; }
		/// <summary>
		/// Shadow root type.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.ShadowRootType ShadowRootType { get; set; }
		/// <summary>
		/// Whether this DOM node responds to mouse clicks. This includes nodes that have had click
		/// event listeners attached via JavaScript as well as anchor tags that naturally navigate when
		/// clicked.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IsClickable { get; set; }
		/// <summary>
		/// Details of the node's event listeners, if any.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOMDebugger.EventListener[] EventListeners { get; set; }
		/// <summary>
		/// The selected url for nodes with a srcset attribute.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string CurrentSourceURL { get; set; }
		/// <summary>
		/// The url of the script (if any) that generates this node.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string OriginURL { get; set; }
		/// <summary>
		/// Scroll offsets, set when this node is a Document.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double ScrollOffsetX { get; set; }
		/// <summary>
		/// ScrollOffsetY
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double ScrollOffsetY { get; set; }
	}
}
