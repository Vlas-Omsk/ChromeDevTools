using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Moves node into the new container, places it before the given anchor.
	/// </summary>

	[SupportedBy("Chrome")]
	public class MoveToCommandParams: ICommandParams<MoveToCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.MoveTo;
		/// <summary>
		/// Id of the node to move.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Id of the element to drop the moved node into.
		/// </summary>
		public long TargetNodeId { get; set; }
		/// <summary>
		/// Drop node before this one (if absent, the moved node becomes the last child of
		/// `targetNodeId`).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? InsertBeforeNodeId { get; set; }
	}
}
