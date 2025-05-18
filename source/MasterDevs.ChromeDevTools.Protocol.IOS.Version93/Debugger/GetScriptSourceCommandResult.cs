using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Debugger
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
