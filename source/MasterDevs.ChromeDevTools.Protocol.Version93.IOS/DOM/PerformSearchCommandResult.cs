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
