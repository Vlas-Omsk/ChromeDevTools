using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Debugger
{
	/// <summary>
	/// Location in the source code.
	/// </summary>
	[SupportedBy("Chrome")]
	public class Location
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
	}
}
