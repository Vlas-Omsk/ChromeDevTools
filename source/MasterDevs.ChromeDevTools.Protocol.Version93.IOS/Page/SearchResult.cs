using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Page
{
	/// <summary>
	/// Search result for resource.
	/// </summary>
	[SupportedBy("IOS")]
	public class SearchResult
	{
		/// <summary>
		/// Resource URL.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Resource frame id.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Number of matches in the resource content.
		/// </summary>
		public double MatchesCount { get; set; }
	}
}
