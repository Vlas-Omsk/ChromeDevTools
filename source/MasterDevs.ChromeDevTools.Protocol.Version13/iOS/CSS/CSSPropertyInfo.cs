using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	[SupportedBy("iOS")]
	public class CSSPropertyInfo
	{
		/// <summary>
		/// Property name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Longhand property names.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] Longhands { get; set; }
		/// <summary>
		/// Supported values for this property.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] Values { get; set; }
	}
}
