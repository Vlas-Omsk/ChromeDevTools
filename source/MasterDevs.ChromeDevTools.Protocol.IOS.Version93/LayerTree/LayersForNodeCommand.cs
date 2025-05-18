using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.LayerTree
{
	/// <summary>
	/// Returns the layer tree structure of the current page.
	/// </summary>

	[SupportedBy("IOS")]
	public class LayersForNodeCommand: ICommand<LayersForNodeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.LayerTree.LayersForNode;
		/// <summary>
		/// Root of the subtree for which we want to gather layers.
		/// </summary>
		public long NodeId { get; set; }
	}
}
