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
	public class GetScriptSourceCommandParams: ICommandParams<GetScriptSourceCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.GetScriptSource;
		/// <summary>
		/// Id of the script to get source for.
		/// </summary>
		public string ScriptId { get; set; }
	}
}
