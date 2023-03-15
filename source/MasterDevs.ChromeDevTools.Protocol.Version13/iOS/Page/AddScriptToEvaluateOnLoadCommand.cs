using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	[Command(ProtocolName.Page.AddScriptToEvaluateOnLoad)]
	[SupportedBy("iOS")]
	public class AddScriptToEvaluateOnLoadCommand: IProtocolCommand<AddScriptToEvaluateOnLoadCommandResponse>
	{
		/// <summary>
		/// ScriptSource
		/// </summary>
		public string ScriptSource { get; set; }
	}
}
