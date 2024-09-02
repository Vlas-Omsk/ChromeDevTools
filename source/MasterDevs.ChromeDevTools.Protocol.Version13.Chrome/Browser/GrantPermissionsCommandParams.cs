using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Browser
{
	/// <summary>
	/// Grant specific permissions to the given origin and reject all others.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GrantPermissionsCommandParams: ICommandParams<GrantPermissionsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Browser.GrantPermissions;
		/// <summary>
		/// Permissions
		/// </summary>
		public string[] Permissions { get; set; }
		/// <summary>
		/// Origin the permission applies to, all origins if not specified.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Origin { get; set; }
		/// <summary>
		/// BrowserContext to override permissions. When omitted, default browser context is used.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string BrowserContextId { get; set; }
	}
}
