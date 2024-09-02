using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOM
{
	/// <summary>
	/// Resolves JavaScript node object for given node id.
	/// </summary>

	[SupportedBy("IOS")]
	public class ResolveNodeCommandParams: ICommandParams<ResolveNodeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.ResolveNode;
		/// <summary>
		/// Id of the node to resolve.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Symbolic group name that can be used to release multiple objects.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ObjectGroup { get; set; }
	}
}
