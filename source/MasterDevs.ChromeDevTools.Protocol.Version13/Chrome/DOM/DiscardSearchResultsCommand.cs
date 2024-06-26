using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Discards search results from the session with the given id. `getSearchResults` should no longer
	/// be called for that search.
	/// </summary>
	[Command(ProtocolName.DOM.DiscardSearchResults)]
	[SupportedBy("Chrome")]
	public class DiscardSearchResultsCommand: IProtocolCommand<DiscardSearchResultsCommandResponse>
	{
		/// <summary>
		/// Unique search session identifier.
		/// </summary>
		public string SearchId { get; set; }
	}
}
