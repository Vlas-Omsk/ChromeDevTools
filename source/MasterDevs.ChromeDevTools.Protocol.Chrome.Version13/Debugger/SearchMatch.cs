using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Debugger
{
	/// <summary>
	/// Search match for resource.
	/// </summary>
	[SupportedBy("Chrome")]
	public class SearchMatch
	{
		/// <summary>
		/// Line number in resource content.
		/// </summary>
		public double LineNumber { get; set; }
		/// <summary>
		/// Line with match content.
		/// </summary>
		public string LineContent { get; set; }
	}
}
