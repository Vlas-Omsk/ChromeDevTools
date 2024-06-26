using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Searches for given string in response content.
	/// </summary>
	[Command(ProtocolName.Network.SearchInResponseBody)]
	[SupportedBy("Chrome")]
	public class SearchInResponseBodyCommand: IProtocolCommand<SearchInResponseBodyCommandResponse>
	{
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
