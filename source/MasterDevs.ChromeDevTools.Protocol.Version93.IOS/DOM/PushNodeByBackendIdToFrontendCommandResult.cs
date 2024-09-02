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
	public class PushNodeByBackendIdToFrontendCommandResult : ICommandResult
	{
		/// <summary>
		/// The pushed node's id.
		/// </summary>
		public long NodeId { get; set; }
	}
}
