using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOM
{
	/// <summary>
	/// Discards search results from the session with the given id. `getSearchResults` should no longer
	/// be called for that search.
	/// </summary>

	[SupportedBy("Chrome")]
	public class DiscardSearchResultsCommand: ICommand<DiscardSearchResultsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.DiscardSearchResults;
		/// <summary>
		/// Unique search session identifier.
		/// </summary>
		public string SearchId { get; set; }
	}
}
