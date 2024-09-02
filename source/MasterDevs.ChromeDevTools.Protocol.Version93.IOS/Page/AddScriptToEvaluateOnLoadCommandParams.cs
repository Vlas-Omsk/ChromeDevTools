using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Page
{

	[SupportedBy("IOS")]
	public class AddScriptToEvaluateOnLoadCommandParams: ICommandParams<AddScriptToEvaluateOnLoadCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.AddScriptToEvaluateOnLoad;
		/// <summary>
		/// ScriptSource
		/// </summary>
		public string ScriptSource { get; set; }
	}
}
