using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.ApplicationCache
{
	/// <summary>
	/// Detailed application cache resource information.
	/// </summary>
	[SupportedBy("iOS")]
	public class ApplicationCacheResource
	{
		/// <summary>
		/// Resource url.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Resource size.
		/// </summary>
		public long Size { get; set; }
		/// <summary>
		/// Resource type.
		/// </summary>
		public string Type { get; set; }
	}
}
