using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	[SupportedBy("iOS")]
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
	}
}
