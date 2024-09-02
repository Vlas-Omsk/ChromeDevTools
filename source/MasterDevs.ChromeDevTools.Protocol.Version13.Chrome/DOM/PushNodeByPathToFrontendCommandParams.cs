using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Requests that the node is sent to the caller given its path. // FIXME, use XPath
	/// </summary>

	[SupportedBy("Chrome")]
	public class PushNodeByPathToFrontendCommandParams: ICommandParams<PushNodeByPathToFrontendCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.PushNodeByPathToFrontend;
		/// <summary>
		/// Path to node in the proprietary format.
		/// </summary>
		public string Path { get; set; }
	}
}
