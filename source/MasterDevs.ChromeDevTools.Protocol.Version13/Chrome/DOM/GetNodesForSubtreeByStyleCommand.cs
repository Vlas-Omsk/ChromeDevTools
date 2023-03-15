using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Finds nodes with a given computed style in a subtree.
	/// </summary>
	[Command(ProtocolName.DOM.GetNodesForSubtreeByStyle)]
	[SupportedBy("Chrome")]
	public class GetNodesForSubtreeByStyleCommand: IProtocolCommand<GetNodesForSubtreeByStyleCommandResponse>
	{
		/// <summary>
		/// Node ID pointing to the root of a subtree.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// The style to filter nodes by (includes nodes if any of properties matches).
		/// </summary>
		public CSSComputedStyleProperty[] ComputedStyles { get; set; }
		/// <summary>
		/// Whether or not iframes and shadow roots in the same target should be traversed when returning the
		/// results (default is false).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Pierce { get; set; }
	}
}
