using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Gets stack traces associated with a Node. As of now, only provides stack trace for Node creation.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetNodeStackTracesCommandParams: ICommandParams<GetNodeStackTracesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.GetNodeStackTraces;
		/// <summary>
		/// Id of the node to get stack traces for.
		/// </summary>
		public long NodeId { get; set; }
	}
}
