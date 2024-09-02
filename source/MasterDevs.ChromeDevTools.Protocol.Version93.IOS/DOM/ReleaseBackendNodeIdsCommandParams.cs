using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOM
{
	/// <summary>
	/// Requests that group of <code>BackendNodeIds</code> is released.
	/// </summary>

	[SupportedBy("IOS")]
	public class ReleaseBackendNodeIdsCommandParams: ICommandParams<ReleaseBackendNodeIdsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.ReleaseBackendNodeIds;
		/// <summary>
		/// The backend node ids group name.
		/// </summary>
		public string NodeGroup { get; set; }
	}
}
