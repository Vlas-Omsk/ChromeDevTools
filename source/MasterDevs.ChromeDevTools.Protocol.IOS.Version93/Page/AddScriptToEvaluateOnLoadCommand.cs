using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Page
{

	[SupportedBy("IOS")]
	public class AddScriptToEvaluateOnLoadCommand: ICommand<AddScriptToEvaluateOnLoadCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.AddScriptToEvaluateOnLoad;
		/// <summary>
		/// ScriptSource
		/// </summary>
		public string ScriptSource { get; set; }
	}
}
