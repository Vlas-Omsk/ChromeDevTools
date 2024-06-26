using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Debugger
{
	/// <summary>
	/// Location in the source code.
	/// </summary>
	[SupportedBy("iOS")]
	public class Location
	{
		/// <summary>
		/// Script identifier as reported in the <code>Debugger.scriptParsed</code>.
		/// </summary>
		public string ScriptId { get; set; }
		/// <summary>
		/// Line number in the script.
		/// </summary>
		public long LineNumber { get; set; }
		/// <summary>
		/// Column number in the script.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ColumnNumber { get; set; }
	}
}
