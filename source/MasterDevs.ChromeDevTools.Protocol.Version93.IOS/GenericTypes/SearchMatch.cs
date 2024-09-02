using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.GenericTypes
{
	/// <summary>
	/// Search match in a resource.
	/// </summary>
	[SupportedBy("IOS")]
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
