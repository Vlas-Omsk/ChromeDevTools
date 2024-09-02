using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Deprecated, please use addScriptToEvaluateOnNewDocument instead.
	/// </summary>
	[Obsolete("Deprecated, please use addScriptToEvaluateOnNewDocument instead.")]

	[SupportedBy("Chrome")]
	public class AddScriptToEvaluateOnLoadCommandResult : ICommandResult
	{
		/// <summary>
		/// Identifier of the added script.
		/// </summary>
		public string Identifier { get; set; }
	}
}
