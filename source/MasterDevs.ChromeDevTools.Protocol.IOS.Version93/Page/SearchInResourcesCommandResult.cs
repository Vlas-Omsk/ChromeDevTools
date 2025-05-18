using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Page
{
	/// <summary>
	/// Searches for given string in frame / resource tree structure.
	/// </summary>

	[SupportedBy("IOS")]
	public class SearchInResourcesCommandResult : ICommandResult
	{
		/// <summary>
		/// List of search results.
		/// </summary>
		public SearchResult[] Result { get; set; }
	}
}
