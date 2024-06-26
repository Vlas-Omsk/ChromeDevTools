using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Creates a deep copy of the specified node and places it into the target container before the
	/// given anchor.
	/// </summary>
	[Command(ProtocolName.DOM.CopyTo)]
	[SupportedBy("Chrome")]
	public class CopyToCommand: IProtocolCommand<CopyToCommandResponse>
	{
		/// <summary>
		/// Id of the node to copy.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Id of the element to drop the copy into.
		/// </summary>
		public long TargetNodeId { get; set; }
		/// <summary>
		/// Drop the copy before this node (if absent, the copy becomes the last child of
		/// `targetNodeId`).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? InsertBeforeNodeId { get; set; }
	}
}
