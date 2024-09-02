using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Discards search results from the session with the given id. `getSearchResults` should no longer
	/// be called for that search.
	/// </summary>

	[SupportedBy("Chrome")]
	public class DiscardSearchResultsCommandParams: ICommandParams<DiscardSearchResultsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.DiscardSearchResults;
		/// <summary>
		/// Unique search session identifier.
		/// </summary>
		public string SearchId { get; set; }
	}
}
