using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Browser
{
	/// <summary>
	/// Set permission settings for given origin.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetPermissionCommandParams: ICommandParams<SetPermissionCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Browser.SetPermission;
		/// <summary>
		/// Descriptor of permission to override.
		/// </summary>
		public PermissionDescriptor Permission { get; set; }
		/// <summary>
		/// Setting of the permission.
		/// </summary>
		public string Setting { get; set; }
		/// <summary>
		/// Origin the permission applies to, all origins if not specified.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Origin { get; set; }
		/// <summary>
		/// Context to override. When omitted, default browser context is used.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string BrowserContextId { get; set; }
	}
}
