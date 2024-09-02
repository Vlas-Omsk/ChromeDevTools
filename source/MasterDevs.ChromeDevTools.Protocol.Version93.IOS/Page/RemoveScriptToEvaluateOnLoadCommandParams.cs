using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Page
{

	[SupportedBy("IOS")]
	public class RemoveScriptToEvaluateOnLoadCommandParams: ICommandParams<RemoveScriptToEvaluateOnLoadCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.RemoveScriptToEvaluateOnLoad;
		/// <summary>
		/// Identifier
		/// </summary>
		public string Identifier { get; set; }
	}
}
