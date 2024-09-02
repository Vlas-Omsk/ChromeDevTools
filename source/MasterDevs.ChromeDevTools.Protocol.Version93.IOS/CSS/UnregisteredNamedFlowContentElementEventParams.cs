using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.CSS
{
	/// <summary>
	/// Fires when a Named Flow's has been registered with a new content node.
	/// </summary>
	[EventName(ProtocolName.CSS.UnregisteredNamedFlowContentElement)]
	[SupportedBy("IOS")]
	public class UnregisteredNamedFlowContentElementEventParams : IEventParams
	{
		/// <summary>
		/// The document node id.
		/// </summary>
		public long DocumentNodeId { get; set; }
		/// <summary>
		/// Named Flow identifier for which the new content element was unregistered.
		/// </summary>
		public string FlowName { get; set; }
		/// <summary>
		/// The node id of the unregistered content node.
		/// </summary>
		public long ContentNodeId { get; set; }
	}
}
