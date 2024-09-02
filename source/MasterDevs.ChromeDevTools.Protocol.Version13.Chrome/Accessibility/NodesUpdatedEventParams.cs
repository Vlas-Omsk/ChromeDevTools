using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Accessibility
{
	/// <summary>
	/// The nodesUpdated event is sent every time a previously requested node has changed the in tree.
	/// </summary>
	[EventName(ProtocolName.Accessibility.NodesUpdated)]
	[SupportedBy("Chrome")]
	public class NodesUpdatedEventParams : IEventParams
	{
		/// <summary>
		/// Updated node data.
		/// </summary>
		public AXNode[] Nodes { get; set; }
	}
}
