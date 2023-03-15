using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Searches for given string in resource content.
	/// </summary>
	[Command(ProtocolName.Page.SearchInResource)]
	[SupportedBy("Chrome")]
	public class SearchInResourceCommand: IProtocolCommand<SearchInResourceCommandResponse>
	{
		/// <summary>
		/// Frame id for resource to search in.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// URL of the resource to search in.
		/// </summary>
		public string Url { get; set; }
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
