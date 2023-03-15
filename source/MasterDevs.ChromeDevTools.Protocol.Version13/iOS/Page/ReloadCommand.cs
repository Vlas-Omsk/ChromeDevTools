using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Reloads given page optionally ignoring the cache.
	/// </summary>
	[Command(ProtocolName.Page.Reload)]
	[SupportedBy("iOS")]
	public class ReloadCommand: IProtocolCommand<ReloadCommandResponse>
	{
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
