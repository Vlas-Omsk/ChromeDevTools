using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Page
{

	[SupportedBy("IOS")]
	public class RemoveScriptToEvaluateOnLoadCommand: ICommand<RemoveScriptToEvaluateOnLoadCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.RemoveScriptToEvaluateOnLoad;
		/// <summary>
		/// Identifier
		/// </summary>
		public string Identifier { get; set; }
	}
}
