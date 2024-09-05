using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Runtime
{
	/// <summary>
	/// Object internal property descriptor. This property isn't normally visible in JavaScript code.
	/// </summary>
	[SupportedBy("IOS")]
	public class InternalPropertyDescriptor
	{
		/// <summary>
		/// Conventional property name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// The value associated with the property.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RemoteObject Value { get; set; }
	}
}