using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Browser
{
	/// <summary>
	/// Cancel a download if in progress
	/// </summary>

	[SupportedBy("Chrome")]
	public class CancelDownloadCommandParams: ICommandParams<CancelDownloadCommandResult>
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
