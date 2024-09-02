using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Page
{
	/// <summary>
	/// Searches for given string in frame / resource tree structure.
	/// </summary>

	[SupportedBy("IOS")]
	public class SearchInResourcesCommandParams: ICommandParams<SearchInResourcesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.SearchInResources;
		/// <summary>
		/// String to search for.
		/// </summary>
		public string Text { get; set; }
		/// <summary>
		/// If true, search is case sensitive.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? CaseSensitive { get; set; }
		/// <summary>
		/// If true, treats string parameter as regex.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IsRegex { get; set; }
	}
}
