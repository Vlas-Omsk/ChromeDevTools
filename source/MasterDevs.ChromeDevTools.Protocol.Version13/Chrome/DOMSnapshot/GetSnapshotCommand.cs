using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMSnapshot
{
	/// <summary>
	/// Returns a document snapshot, including the full DOM tree of the root node (including iframes,
	/// template contents, and imported documents) in a flattened array, as well as layout and
	/// white-listed computed style information for the nodes. Shadow DOM in the returned DOM tree is
	/// flattened.
	/// </summary>
	[Obsolete]
	[Command(ProtocolName.DOMSnapshot.GetSnapshot)]
	[SupportedBy("Chrome")]
	public class GetSnapshotCommand: ICommandParams<GetSnapshotCommandResponse>
	{
		/// <summary>
		/// Whitelist of computed styles to return.
		/// </summary>
		public string[] ComputedStyleWhitelist { get; set; }
		/// <summary>
		/// Whether or not to retrieve details of DOM listeners (default false).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IncludeEventListeners { get; set; }
		/// <summary>
		/// Whether to determine and include the paint order index of LayoutTreeNodes (default false).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IncludePaintOrder { get; set; }
		/// <summary>
		/// Whether to include UA shadow tree in the snapshot (default false).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IncludeUserAgentShadowTree { get; set; }
	}
}
