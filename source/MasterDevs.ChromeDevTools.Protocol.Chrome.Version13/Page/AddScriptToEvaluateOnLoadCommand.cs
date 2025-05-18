using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page
{
	/// <summary>
	/// Deprecated, please use addScriptToEvaluateOnNewDocument instead.
	/// </summary>
	[Obsolete("Deprecated, please use addScriptToEvaluateOnNewDocument instead.")]

	[SupportedBy("Chrome")]
	public class AddScriptToEvaluateOnLoadCommand: ICommand<AddScriptToEvaluateOnLoadCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.AddScriptToEvaluateOnLoad;
		/// <summary>
		/// ScriptSource
		/// </summary>
		public string ScriptSource { get; set; }
	}
}
