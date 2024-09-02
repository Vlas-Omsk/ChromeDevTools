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
	public class PerformSearchCommandResult : ICommandResult
	{
		/// <summary>
		/// Unique search session identifier.
		/// </summary>
		public string SearchId { get; set; }
		/// <summary>
		/// Number of search results.
		/// </summary>
		public long ResultCount { get; set; }
	}
}
