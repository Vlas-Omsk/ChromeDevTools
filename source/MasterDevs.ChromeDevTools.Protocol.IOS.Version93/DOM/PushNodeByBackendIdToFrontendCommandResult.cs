using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.DOM
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
