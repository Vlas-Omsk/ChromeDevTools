using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOM
{
	/// <summary>
	/// Requests that the node is sent to the caller given its path. // FIXME, use XPath
	/// </summary>

	[SupportedBy("IOS")]
	public class PushNodeByPathToFrontendCommandResult : ICommandResult
	{
		/// <summary>
		/// Id of the node for given path.
		/// </summary>
		public long NodeId { get; set; }
	}
}
