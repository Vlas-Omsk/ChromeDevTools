using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{

	[SupportedBy("Chrome")]
	public class GetAdScriptIdCommandResult : ICommandResult
	{
		/// <summary>
		/// Identifies the bottom-most script which caused the frame to be labelled
		/// as an ad. Only sent if frame is labelled as an ad and id is available.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AdScriptId AdScriptId { get; set; }
	}
}
