using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Requests that a batch of nodes is sent to the caller given their backend node ids.
	/// </summary>

	[SupportedBy("Chrome")]
	public class PushNodesByBackendIdsToFrontendCommandParams: ICommandParams<PushNodesByBackendIdsToFrontendCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.PushNodesByBackendIdsToFrontend;
		/// <summary>
		/// The array of backend node ids.
		/// </summary>
		public long[] BackendNodeIds { get; set; }
	}
}
