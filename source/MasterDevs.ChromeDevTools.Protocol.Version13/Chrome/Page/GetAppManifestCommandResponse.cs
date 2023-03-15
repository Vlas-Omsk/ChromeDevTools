using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	[CommandResponse(ProtocolName.Page.GetAppManifest)]
	[SupportedBy("Chrome")]
	public class GetAppManifestCommandResponse
	{
		/// <summary>
		/// Manifest location.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Errors
		/// </summary>
		public AppManifestError[] Errors { get; set; }
		/// <summary>
		/// Manifest content.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Data { get; set; }
		/// <summary>
		/// Parsed manifest properties
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AppManifestParsedProperties Parsed { get; set; }
	}
}
