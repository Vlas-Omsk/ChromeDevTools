using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Runtime
{
	[SupportedBy("iOS")]
	public class CollectionEntry
	{
		/// <summary>
		/// Entry key of a map-like collection, otherwise not provided.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Runtime.RemoteObject Key { get; set; }
		/// <summary>
		/// Entry value.
		/// </summary>
		public Runtime.RemoteObject Value { get; set; }
	}
}
