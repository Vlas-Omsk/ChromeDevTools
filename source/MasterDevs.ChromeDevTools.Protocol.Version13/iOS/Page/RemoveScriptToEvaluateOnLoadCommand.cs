using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	[Command(ProtocolName.Page.RemoveScriptToEvaluateOnLoad)]
	[SupportedBy("iOS")]
	public class RemoveScriptToEvaluateOnLoadCommand: ICommandParams<RemoveScriptToEvaluateOnLoadCommandResponse>
	{
		/// <summary>
		/// Identifier
		/// </summary>
		public string Identifier { get; set; }
	}
}
