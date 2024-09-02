using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Page
{
	/// <summary>
	/// Reloads given page optionally ignoring the cache.
	/// </summary>

	[SupportedBy("IOS")]
	public class ReloadCommandParams: ICommandParams<ReloadCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.Reload;
		/// <summary>
		/// If true, browser cache is ignored (as if the user pressed Shift+refresh).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IgnoreCache { get; set; }
		/// <summary>
		/// If set, the script will be injected into all frames of the inspected page after reload.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ScriptToEvaluateOnLoad { get; set; }
	}
}
