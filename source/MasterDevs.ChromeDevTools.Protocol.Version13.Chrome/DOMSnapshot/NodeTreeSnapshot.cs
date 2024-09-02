using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOMSnapshot
{
	/// <summary>
	/// Table containing nodes.
	/// </summary>
	[SupportedBy("Chrome")]
	public class NodeTreeSnapshot
	{
		/// <summary>
		/// Parent node index.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long[] ParentIndex { get; set; }
		/// <summary>
		/// `Node`'s nodeType.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long[] NodeType { get; set; }
		/// <summary>
		/// Type of the shadow root the `Node` is in. String values are equal to the `ShadowRootType` enum.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RareStringData ShadowRootType { get; set; }
		/// <summary>
		/// `Node`'s nodeName.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long[] NodeName { get; set; }
		/// <summary>
		/// `Node`'s nodeValue.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long[] NodeValue { get; set; }
		/// <summary>
		/// `Node`'s id, corresponds to DOM.Node.backendNodeId.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long[] BackendNodeId { get; set; }
		/// <summary>
		/// Attributes of an `Element` node. Flatten name, value pairs.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long[][] Attributes { get; set; }
		/// <summary>
		/// Only set for textarea elements, contains the text value.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RareStringData TextValue { get; set; }
		/// <summary>
		/// Only set for input elements, contains the input's associated text value.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RareStringData InputValue { get; set; }
		/// <summary>
		/// Only set for radio and checkbox input elements, indicates if the element has been checked
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RareBooleanData InputChecked { get; set; }
		/// <summary>
		/// Only set for option elements, indicates if the element has been selected
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RareBooleanData OptionSelected { get; set; }
		/// <summary>
		/// The index of the document in the list of the snapshot documents.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RareIntegerData ContentDocumentIndex { get; set; }
		/// <summary>
		/// Type of a pseudo element node.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RareStringData PseudoType { get; set; }
		/// <summary>
		/// Pseudo element identifier for this node. Only present if there is a
		/// valid pseudoType.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RareStringData PseudoIdentifier { get; set; }
		/// <summary>
		/// Whether this DOM node responds to mouse clicks. This includes nodes that have had click
		/// event listeners attached via JavaScript as well as anchor tags that naturally navigate when
		/// clicked.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RareBooleanData IsClickable { get; set; }
		/// <summary>
		/// The selected url for nodes with a srcset attribute.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RareStringData CurrentSourceURL { get; set; }
		/// <summary>
		/// The url of the script (if any) that generates this node.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RareStringData OriginURL { get; set; }
	}
}
