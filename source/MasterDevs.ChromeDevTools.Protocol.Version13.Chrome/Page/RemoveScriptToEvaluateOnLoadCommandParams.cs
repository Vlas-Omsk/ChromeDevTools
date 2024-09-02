using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Deprecated, please use removeScriptToEvaluateOnNewDocument instead.
	/// </summary>
	[Obsolete("Deprecated, please use removeScriptToEvaluateOnNewDocument instead.")]

	[SupportedBy("Chrome")]
	public class RemoveScriptToEvaluateOnLoadCommandParams: ICommandParams<RemoveScriptToEvaluateOnLoadCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.RemoveScriptToEvaluateOnLoad;
		/// <summary>
		/// Identifier
		/// </summary>
		public string Identifier { get; set; }
	}
}
