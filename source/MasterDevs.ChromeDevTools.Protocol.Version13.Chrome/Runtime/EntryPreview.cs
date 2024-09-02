using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Runtime
{
	[SupportedBy("Chrome")]
	public class EntryPreview
	{
		/// <summary>
		/// Preview of the key. Specified for map-like collection entries.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ObjectPreview Key { get; set; }
		/// <summary>
		/// Preview of the value.
		/// </summary>
		public ObjectPreview Value { get; set; }
	}
}
