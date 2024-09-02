using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOM
{
	/// <summary>
	/// Discards search results from the session with the given id. <code>getSearchResults</code> should no longer be called for that search.
	/// </summary>

	[SupportedBy("IOS")]
	public class DiscardSearchResultsCommandParams: ICommandParams<DiscardSearchResultsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.DiscardSearchResults;
		/// <summary>
		/// Unique search session identifier.
		/// </summary>
		public string SearchId { get; set; }
	}
}
