using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Debugger
{
	/// <summary>
	/// Searches for given string in script content.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SearchInContentCommandParams: ICommandParams<SearchInContentCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.SearchInContent;
		/// <summary>
		/// Id of the script to search in.
		/// </summary>
		public string ScriptId { get; set; }
		/// <summary>
		/// String to search for.
		/// </summary>
		public string Query { get; set; }
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
