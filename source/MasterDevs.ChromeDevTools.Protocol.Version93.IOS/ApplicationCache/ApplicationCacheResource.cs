using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.ApplicationCache
{
	/// <summary>
	/// Detailed application cache resource information.
	/// </summary>
	[SupportedBy("IOS")]
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
