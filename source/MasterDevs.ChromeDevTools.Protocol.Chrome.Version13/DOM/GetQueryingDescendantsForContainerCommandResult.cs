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
	public class GetQueryingDescendantsForContainerCommandResult : ICommandResult
	{
		/// <summary>
		/// Descendant nodes with container queries against the given container.
		/// </summary>
		public long[] NodeIds { get; set; }
	}
}
