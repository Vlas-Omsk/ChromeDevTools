using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOM
{
	/// <summary>
	/// Requests that a batch of nodes is sent to the caller given their backend node ids.
	/// </summary>

	[SupportedBy("Chrome")]
	public class PushNodesByBackendIdsToFrontendCommand: ICommand<PushNodesByBackendIdsToFrontendCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.PushNodesByBackendIdsToFrontend;
		/// <summary>
		/// The array of backend node ids.
		/// </summary>
		public long[] BackendNodeIds { get; set; }
	}
}
