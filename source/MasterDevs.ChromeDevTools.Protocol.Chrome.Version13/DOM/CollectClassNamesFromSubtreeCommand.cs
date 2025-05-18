using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOM
{
	/// <summary>
	/// Collects class names for the node with given id and all of it's child nodes.
	/// </summary>

	[SupportedBy("Chrome")]
	public class CollectClassNamesFromSubtreeCommand: ICommand<CollectClassNamesFromSubtreeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.CollectClassNamesFromSubtree;
		/// <summary>
		/// Id of the node to collect class names.
		/// </summary>
		public long NodeId { get; set; }
	}
}
