using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Runtime
{
	[SupportedBy("IOS")]
	public class EntryPreview
	{
		/// <summary>
		/// Entry key. Specified for map-like collection entries.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ObjectPreview Key { get; set; }
		/// <summary>
		/// Entry value.
		/// </summary>
		public ObjectPreview Value { get; set; }
	}
}
