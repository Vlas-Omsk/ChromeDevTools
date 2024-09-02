using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Debugger
{
	[SupportedBy("Chrome")]
	public class BreakLocation
	{
		/// <summary>
		/// Script identifier as reported in the `Debugger.scriptParsed`.
		/// </summary>
		public string ScriptId { get; set; }
		/// <summary>
		/// Line number in the script (0-based).
		/// </summary>
		public long LineNumber { get; set; }
		/// <summary>
		/// Column number in the script (0-based).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ColumnNumber { get; set; }
		/// <summary>
		/// Type
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Type { get; set; }
	}
}
