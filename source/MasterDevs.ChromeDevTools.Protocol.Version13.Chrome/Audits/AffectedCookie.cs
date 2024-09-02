using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Audits
{
	/// <summary>
	/// Information about a cookie that is affected by an inspector issue.
	/// </summary>
	[SupportedBy("Chrome")]
	public class AffectedCookie
	{
		/// <summary>
		/// The following three properties uniquely identify a cookie
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Path
		/// </summary>
		public string Path { get; set; }
		/// <summary>
		/// Domain
		/// </summary>
		public string Domain { get; set; }
	}
}
