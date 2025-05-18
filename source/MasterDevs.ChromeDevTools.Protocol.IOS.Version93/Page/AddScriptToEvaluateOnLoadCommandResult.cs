using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Page
{

	[SupportedBy("IOS")]
	public class AddScriptToEvaluateOnLoadCommandResult : ICommandResult
	{
		/// <summary>
		/// Identifier of the added script.
		/// </summary>
		public string Identifier { get; set; }
	}
}
