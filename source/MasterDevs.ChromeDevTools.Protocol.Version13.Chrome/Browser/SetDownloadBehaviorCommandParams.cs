using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Browser
{
	/// <summary>
	/// Set the behavior when downloading a file.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetDownloadBehaviorCommandParams: ICommandParams<SetDownloadBehaviorCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Browser.SetDownloadBehavior;
		/// <summary>
		/// Whether to allow all or deny all download requests, or use default Chrome behavior if
		/// available (otherwise deny). |allowAndName| allows download and names files according to
		/// their dowmload guids.
		/// </summary>
		public string Behavior { get; set; }
		/// <summary>
		/// BrowserContext to set download behavior. When omitted, default browser context is used.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string BrowserContextId { get; set; }
		/// <summary>
		/// The default path to save downloaded files to. This is required if behavior is set to 'allow'
		/// or 'allowAndName'.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string DownloadPath { get; set; }
		/// <summary>
		/// Whether to emit download events (defaults to false).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? EventsEnabled { get; set; }
	}
}
