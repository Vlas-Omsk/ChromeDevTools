using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Debugger
{
	/// <summary>
	/// Fired when virtual machine fails to parse the script.
	/// </summary>
	[EventName(ProtocolName.Debugger.ScriptFailedToParse)]
	[SupportedBy("IOS")]
	public class ScriptFailedToParseEventParams : IEventParams
	{
		/// <summary>
		/// URL of the script that failed to parse.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Source text of the script that failed to parse.
		/// </summary>
		public string ScriptSource { get; set; }
		/// <summary>
		/// Line offset of the script within the resource.
		/// </summary>
		public long StartLine { get; set; }
		/// <summary>
		/// Line with error.
		/// </summary>
		public long ErrorLine { get; set; }
		/// <summary>
		/// Parse error message.
		/// </summary>
		public string ErrorMessage { get; set; }
	}
}
