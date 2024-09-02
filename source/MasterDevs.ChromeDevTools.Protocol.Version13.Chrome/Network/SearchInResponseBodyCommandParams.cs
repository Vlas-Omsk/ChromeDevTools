using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Searches for given string in response content.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SearchInResponseBodyCommandParams: ICommandParams<SearchInResponseBodyCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.SearchInResponseBody;
		/// <summary>
		/// Identifier of the network response to search.
		/// </summary>
		public string RequestId { get; set; }
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
