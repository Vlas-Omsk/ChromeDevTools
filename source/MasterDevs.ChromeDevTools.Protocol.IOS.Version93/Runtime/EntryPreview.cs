using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Runtime
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
