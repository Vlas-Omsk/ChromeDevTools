using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOM
{
	/// <summary>
	/// Returns the descendants of a container query container that have
	/// container queries against this container.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetQueryingDescendantsForContainerCommand: ICommand<GetQueryingDescendantsForContainerCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.GetQueryingDescendantsForContainer;
		/// <summary>
		/// Id of the container node to find querying descendants from.
		/// </summary>
		public long NodeId { get; set; }
	}
}
