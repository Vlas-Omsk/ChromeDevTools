using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Debugger
{
	/// <summary>
	/// Returns source for the script with given id.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetScriptSourceCommandResult : ICommandResult
	{
		/// <summary>
		/// Script source.
		/// </summary>
		public string ScriptSource { get; set; }
	}
}
