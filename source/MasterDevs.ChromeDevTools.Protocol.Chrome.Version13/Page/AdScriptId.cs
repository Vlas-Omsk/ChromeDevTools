using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page
{
	/// <summary>
	/// Identifies the bottom-most script which caused the frame to be labelled
	/// as an ad.
	/// </summary>
	[SupportedBy("Chrome")]
	public class AdScriptId
	{
		/// <summary>
		/// Script Id of the bottom-most script which caused the frame to be labelled
		/// as an ad.
		/// </summary>
		public string ScriptId { get; set; }
		/// <summary>
		/// Id of adScriptId's debugger.
		/// </summary>
		public string DebuggerId { get; set; }
	}
}
