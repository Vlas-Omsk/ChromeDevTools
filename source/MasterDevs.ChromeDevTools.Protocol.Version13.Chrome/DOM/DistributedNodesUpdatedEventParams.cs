using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Called when distribution is changed.
	/// </summary>
	[EventName(ProtocolName.DOM.DistributedNodesUpdated)]
	[SupportedBy("Chrome")]
	public class DistributedNodesUpdatedEventParams : IEventParams
	{
		/// <summary>
		/// Insertion point where distributed nodes were updated.
		/// </summary>
		public long InsertionPointId { get; set; }
		/// <summary>
		/// Distributed nodes for given insertion point.
		/// </summary>
		public BackendNode[] DistributedNodes { get; set; }
	}
}
