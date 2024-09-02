using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Error while paring app manifest.
	/// </summary>
	[SupportedBy("Chrome")]
	public class AppManifestError
	{
		/// <summary>
		/// Error message.
		/// </summary>
		public string Message { get; set; }
		/// <summary>
		/// If criticial, this is a non-recoverable parse error.
		/// </summary>
		public long Critical { get; set; }
		/// <summary>
		/// Error line.
		/// </summary>
		public long Line { get; set; }
		/// <summary>
		/// Error column.
		/// </summary>
		public long Column { get; set; }
	}
}
