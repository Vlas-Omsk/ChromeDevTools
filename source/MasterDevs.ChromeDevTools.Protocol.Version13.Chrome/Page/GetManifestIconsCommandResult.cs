using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Deprecated because it's not guaranteed that the returned icon is in fact the one used for PWA installation.
	/// </summary>
	[Obsolete("Deprecated because it's not guaranteed that the returned icon is in fact the one used for PWA installation.")]

	[SupportedBy("Chrome")]
	public class GetManifestIconsCommandResult : ICommandResult
	{
		/// <summary>
		/// PrimaryIcon
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string PrimaryIcon { get; set; }
	}
}