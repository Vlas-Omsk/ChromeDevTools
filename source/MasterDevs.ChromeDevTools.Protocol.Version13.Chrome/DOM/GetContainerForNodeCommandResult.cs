using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Returns the query container of the given node based on container query
	/// conditions: containerName, physical, and logical axes. If no axes are
	/// provided, the style container is returned, which is the direct parent or the
	/// closest element with a matching container-name.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetContainerForNodeCommandResult : ICommandResult
	{
		/// <summary>
		/// The container node for the given node, or null if not found.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? NodeId { get; set; }
	}
}
