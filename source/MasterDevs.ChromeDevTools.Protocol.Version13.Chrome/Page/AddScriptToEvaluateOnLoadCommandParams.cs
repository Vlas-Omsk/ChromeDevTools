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
	public class AddScriptToEvaluateOnLoadCommandParams: ICommandParams<AddScriptToEvaluateOnLoadCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.AddScriptToEvaluateOnLoad;
		/// <summary>
		/// ScriptSource
		/// </summary>
		public string ScriptSource { get; set; }
	}
}
