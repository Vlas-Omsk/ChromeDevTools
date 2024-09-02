using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CSS
{
	/// <summary>
	/// Returns all layers parsed by the rendering engine for the tree scope of a node.
	/// Given a DOM element identified by nodeId, getLayersForNode returns the root
	/// layer for the nearest ancestor document or shadow root. The layer root contains
	/// the full layer tree for the tree scope and their ordering.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetLayersForNodeCommandParams: ICommandParams<GetLayersForNodeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.GetLayersForNode;
		/// <summary>
		/// NodeId
		/// </summary>
		public long NodeId { get; set; }
	}
}
