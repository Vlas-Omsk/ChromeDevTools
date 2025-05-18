using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Debugger
{
	/// <summary>
	/// Debug symbols available for a wasm script.
	/// </summary>
	[SupportedBy("Chrome")]
	public class DebugSymbols
	{
		/// <summary>
		/// Type of the debug symbols.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// URL of the external symbol source.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ExternalURL { get; set; }
	}
}
