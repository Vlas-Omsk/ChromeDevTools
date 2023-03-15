using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Searches for given string in frame / resource tree structure.
	/// </summary>
	[CommandResponse(ProtocolName.Page.SearchInResources)]
	[SupportedBy("iOS")]
	public class SearchInResourcesCommandResponse
	{
		/// <summary>
		/// List of search results.
		/// </summary>
		public SearchResult[] Result { get; set; }
	}
}
