using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Returns the root DOM node (and optionally the subtree) to the caller.
	/// Deprecated, as it is not designed to work well with the rest of the DOM agent.
	/// Use DOMSnapshot.captureSnapshot instead.
	/// </summary>
	[Obsolete]
	[Command(ProtocolName.DOM.GetFlattenedDocument)]
	[SupportedBy("Chrome")]
	public class GetFlattenedDocumentCommand: IProtocolCommand<GetFlattenedDocumentCommandResponse>
	{
		/// <summary>
		/// The maximum depth at which children should be retrieved, defaults to 1. Use -1 for the
		/// entire subtree or provide an integer larger than 0.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Depth { get; set; }
		/// <summary>
		/// Whether or not iframes and shadow roots should be traversed when returning the subtree
		/// (default is false).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Pierce { get; set; }
	}
}
