using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Debugger
{
	/// <summary>
	/// Location range within one script.
	/// </summary>
	[SupportedBy("Chrome")]
	public class LocationRange
	{
		/// <summary>
		/// ScriptId
		/// </summary>
		public string ScriptId { get; set; }
		/// <summary>
		/// Start
		/// </summary>
		public ScriptPosition Start { get; set; }
		/// <summary>
		/// End
		/// </summary>
		public ScriptPosition End { get; set; }
	}
}
