using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Browser
{
	/// <summary>
	/// Cancel a download if in progress
	/// </summary>

	[SupportedBy("Chrome")]
	public class CancelDownloadCommand: ICommand<CancelDownloadCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Browser.CancelDownload;
		/// <summary>
		/// Global unique identifier of the download.
		/// </summary>
		public string Guid { get; set; }
		/// <summary>
		/// BrowserContext to perform the action in. When omitted, default browser context is used.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string BrowserContextId { get; set; }
	}
}
