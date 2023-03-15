using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	[SupportedBy("Chrome")]
	public class ShorthandEntry
	{
		/// <summary>
		/// Shorthand name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Shorthand value.
		/// </summary>
		public string Value { get; set; }
		/// <summary>
		/// Whether the property has "!important" annotation (implies `false` if absent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Important { get; set; }
	}
}
