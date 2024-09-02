using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Accessibility
{
	[SupportedBy("Chrome")]
	public class AXProperty
	{
		/// <summary>
		/// The name of this property.
		/// </summary>
		public AXPropertyName Name { get; set; }
		/// <summary>
		/// The value of this property.
		/// </summary>
		public AXValue Value { get; set; }
	}
}
