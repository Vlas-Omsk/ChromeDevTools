using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Requests that the node is sent to the caller given its path. // FIXME, use XPath
	/// </summary>
	[CommandResponse(ProtocolName.DOM.PushNodeByPathToFrontend)]
	[SupportedBy("iOS")]
	public class PushNodeByPathToFrontendCommandResponse
	{
		/// <summary>
		/// Id of the node for given path.
		/// </summary>
		public long NodeId { get; set; }
	}
}
