using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Browser
{
	/// <summary>
	/// Reset all permission management for all origins.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ResetPermissionsCommandParams: ICommandParams<ResetPermissionsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Browser.ResetPermissions;
		/// <summary>
		/// BrowserContext to reset permissions. When omitted, default browser context is used.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string BrowserContextId { get; set; }
	}
}
