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
	public class PushNodesByBackendIdsToFrontendCommandResult : ICommandResult
	{
		/// <summary>
		/// The array of ids of pushed nodes that correspond to the backend ids specified in
		/// backendNodeIds.
		/// </summary>
		public long[] NodeIds { get; set; }
	}
}
