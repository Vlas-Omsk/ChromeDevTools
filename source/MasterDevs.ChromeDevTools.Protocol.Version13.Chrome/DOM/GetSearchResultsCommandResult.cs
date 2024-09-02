using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Returns search results from given `fromIndex` to given `toIndex` from the search with the given
	/// identifier.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetSearchResultsCommandResult : ICommandResult
	{
		/// <summary>
		/// Ids of the search result nodes.
		/// </summary>
		public long[] NodeIds { get; set; }
	}
}
