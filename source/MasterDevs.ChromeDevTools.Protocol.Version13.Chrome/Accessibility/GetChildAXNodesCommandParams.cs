using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Accessibility
{
	/// <summary>
	/// Fetches a particular accessibility node by AXNodeId.
	/// Requires `enable()` to have been called previously.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetChildAXNodesCommandParams: ICommandParams<GetChildAXNodesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Accessibility.GetChildAXNodes;
		/// <summary>
		/// Id
		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// The frame in whose document the node resides.
		/// If omitted, the root frame is used.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string FrameId { get; set; }
	}
}
