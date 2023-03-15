using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Gets stack traces associated with a Node. As of now, only provides stack trace for Node creation.
	/// </summary>
	[Command(ProtocolName.DOM.GetNodeStackTraces)]
	[SupportedBy("Chrome")]
	public class GetNodeStackTracesCommand: IProtocolCommand<GetNodeStackTracesCommandResponse>
	{
		/// <summary>
		/// Id of the node to get stack traces for.
		/// </summary>
		public long NodeId { get; set; }
	}
}
