using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Media
{
	/// <summary>
	/// Represents logged source line numbers reported in an error.
	/// NOTE: file and line are from chromium c++ implementation code, not js.
	/// </summary>
	[SupportedBy("Chrome")]
	public class PlayerErrorSourceLocation
	{
		/// <summary>
		/// File
		/// </summary>
		public string File { get; set; }
		/// <summary>
		/// Line
		/// </summary>
		public long Line { get; set; }
	}
}
