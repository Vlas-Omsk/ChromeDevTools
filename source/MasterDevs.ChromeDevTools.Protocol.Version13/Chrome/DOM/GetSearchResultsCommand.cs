using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Returns search results from given `fromIndex` to given `toIndex` from the search with the given
	/// identifier.
	/// </summary>
	[Command(ProtocolName.DOM.GetSearchResults)]
	[SupportedBy("Chrome")]
	public class GetSearchResultsCommand: ICommandParams<GetSearchResultsCommandResponse>
	{
		/// <summary>
		/// Unique search session identifier.
		/// </summary>
		public string SearchId { get; set; }
		/// <summary>
		/// Start index of the search result to be returned.
		/// </summary>
		public long FromIndex { get; set; }
		/// <summary>
		/// End index of the search result to be returned.
		/// </summary>
		public long ToIndex { get; set; }
	}
}
