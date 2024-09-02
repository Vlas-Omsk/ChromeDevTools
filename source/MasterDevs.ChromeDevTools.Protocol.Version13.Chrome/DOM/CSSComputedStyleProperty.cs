using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	[SupportedBy("Chrome")]
	public class CSSComputedStyleProperty
	{
		/// <summary>
		/// Computed style property name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Computed style property value.
		/// </summary>
		public string Value { get; set; }
	}
}
