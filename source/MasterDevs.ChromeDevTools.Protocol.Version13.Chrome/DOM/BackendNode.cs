using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Backend node with a friendly name.
	/// </summary>
	[SupportedBy("Chrome")]
	public class BackendNode
	{
		/// <summary>
		/// `Node`'s nodeType.
		/// </summary>
		public long NodeType { get; set; }
		/// <summary>
		/// `Node`'s nodeName.
		/// </summary>
		public string NodeName { get; set; }
		/// <summary>
		/// BackendNodeId
		/// </summary>
		public long BackendNodeId { get; set; }
	}
}
