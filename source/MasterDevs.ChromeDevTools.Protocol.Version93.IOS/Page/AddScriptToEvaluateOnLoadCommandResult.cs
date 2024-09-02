using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Page
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
