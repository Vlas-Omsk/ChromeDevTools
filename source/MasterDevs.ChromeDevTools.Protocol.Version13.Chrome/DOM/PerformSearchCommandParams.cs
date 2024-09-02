using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Searches for a given string in the DOM tree. Use `getSearchResults` to access search results or
	/// `cancelSearch` to end this search session.
	/// </summary>

	[SupportedBy("Chrome")]
	public class PerformSearchCommandParams: ICommandParams<PerformSearchCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.PerformSearch;
		/// <summary>
		/// Plain text or query selector or XPath search query.
		/// </summary>
		public string Query { get; set; }
		/// <summary>
		/// True to search in user agent shadow DOM.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IncludeUserAgentShadowDOM { get; set; }
	}
}
