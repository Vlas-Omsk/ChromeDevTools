using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.CSS
{
	[SupportedBy("IOS")]
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
