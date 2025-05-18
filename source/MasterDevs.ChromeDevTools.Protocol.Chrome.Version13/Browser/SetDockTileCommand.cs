using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Browser
{
	/// <summary>
	/// Set dock tile details, platform-specific.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetDockTileCommand: ICommand<SetDockTileCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Browser.SetDockTile;
		/// <summary>
		/// BadgeLabel
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string BadgeLabel { get; set; }
		/// <summary>
		/// Png encoded image. (Encoded as a base64 string when passed over JSON)
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Image { get; set; }
	}
}
