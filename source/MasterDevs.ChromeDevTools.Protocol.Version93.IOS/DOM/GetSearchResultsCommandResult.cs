using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOM
{
	/// <summary>
	/// Returns search results from given <code>fromIndex</code> to given <code>toIndex</code> from the sarch with the given identifier.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetSearchResultsCommandResult : ICommandResult
	{
		/// <summary>
		/// Ids of the search result nodes.
		/// </summary>
		public long[] NodeIds { get; set; }
	}
}
