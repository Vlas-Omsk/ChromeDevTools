using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Parsed app manifest properties.
	/// </summary>
	[SupportedBy("Chrome")]
	public class AppManifestParsedProperties
	{
		/// <summary>
		/// Computed scope value
		/// </summary>
		public string Scope { get; set; }
	}
}
