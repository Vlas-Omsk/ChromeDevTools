using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOM
{
	/// <summary>
	/// Requests that the node is sent to the caller given its backend node id.
	/// </summary>

	[SupportedBy("IOS")]
	public class PushNodeByBackendIdToFrontendCommandParams: ICommandParams<PushNodeByBackendIdToFrontendCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.PushNodeByBackendIdToFrontend;
		/// <summary>
		/// The backend node id of the node.
		/// </summary>
		public long BackendNodeId { get; set; }
	}
}
