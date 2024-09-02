using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOM
{
	/// <summary>
	/// Searches for a given string in the DOM tree. Use <code>getSearchResults</code> to access search results or <code>cancelSearch</code> to end this search session.
	/// </summary>

	[SupportedBy("IOS")]
	public class PerformSearchCommandParams: ICommandParams<PerformSearchCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.PerformSearch;
		/// <summary>
		/// Plain text or query selector or XPath search query.
		/// </summary>
		public string Query { get; set; }
		/// <summary>
		/// Ids of nodes to use as starting points for the search.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long[] NodeIds { get; set; }
	}
}
