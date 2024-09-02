using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Returns the descendants of a container query container that have
	/// container queries against this container.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetQueryingDescendantsForContainerCommandParams: ICommandParams<GetQueryingDescendantsForContainerCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.GetQueryingDescendantsForContainer;
		/// <summary>
		/// Id of the container node to find querying descendants from.
		/// </summary>
		public long NodeId { get; set; }
	}
}
