using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOMSnapshot
{
	/// <summary>
	/// Document snapshot.
	/// </summary>
	[SupportedBy("Chrome")]
	public class DocumentSnapshot
	{
		/// <summary>
		/// Document URL that `Document` or `FrameOwner` node points to.
		/// </summary>
		public long DocumentURL { get; set; }
		/// <summary>
		/// Document title.
		/// </summary>
		public long Title { get; set; }
		/// <summary>
		/// Base URL that `Document` or `FrameOwner` node uses for URL completion.
		/// </summary>
		public long BaseURL { get; set; }
		/// <summary>
		/// Contains the document's content language.
		/// </summary>
		public long ContentLanguage { get; set; }
		/// <summary>
		/// Contains the document's character set encoding.
		/// </summary>
		public long EncodingName { get; set; }
		/// <summary>
		/// `DocumentType` node's publicId.
		/// </summary>
		public long PublicId { get; set; }
		/// <summary>
		/// `DocumentType` node's systemId.
		/// </summary>
		public long SystemId { get; set; }
		/// <summary>
		/// Frame ID for frame owner elements and also for the document node.
		/// </summary>
		public long FrameId { get; set; }
		/// <summary>
		/// A table with dom nodes.
		/// </summary>
		public NodeTreeSnapshot Nodes { get; set; }
		/// <summary>
		/// The nodes in the layout tree.
		/// </summary>
		public LayoutTreeSnapshot Layout { get; set; }
		/// <summary>
		/// The post-layout inline text nodes.
		/// </summary>
		public TextBoxSnapshot TextBoxes { get; set; }
		/// <summary>
		/// Horizontal scroll offset.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double ScrollOffsetX { get; set; }
		/// <summary>
		/// Vertical scroll offset.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double ScrollOffsetY { get; set; }
		/// <summary>
		/// Document content width.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double ContentWidth { get; set; }
		/// <summary>
		/// Document content height.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double ContentHeight { get; set; }
	}
}
