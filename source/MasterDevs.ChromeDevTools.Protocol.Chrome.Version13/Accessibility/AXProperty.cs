using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Accessibility
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
