using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Accessibility
{
	/// <summary>
	/// Fetches the root node.
	/// Requires `enable()` to have been called previously.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetRootAXNodeCommand: ICommand<GetRootAXNodeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Accessibility.GetRootAXNode;
		/// <summary>
		/// The frame in whose document the node resides.
		/// If omitted, the root frame is used.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string FrameId { get; set; }
	}
}
