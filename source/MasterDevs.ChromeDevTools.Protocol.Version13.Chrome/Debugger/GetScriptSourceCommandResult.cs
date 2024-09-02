using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Debugger
{
	/// <summary>
	/// Returns source for the script with given id.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetScriptSourceCommandResult : ICommandResult
	{
		/// <summary>
		/// Script source (empty in case of Wasm bytecode).
		/// </summary>
		public string ScriptSource { get; set; }
		/// <summary>
		/// Wasm bytecode. (Encoded as a base64 string when passed over JSON)
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Bytecode { get; set; }
	}
}
