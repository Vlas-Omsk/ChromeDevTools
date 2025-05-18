using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.CSS
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
