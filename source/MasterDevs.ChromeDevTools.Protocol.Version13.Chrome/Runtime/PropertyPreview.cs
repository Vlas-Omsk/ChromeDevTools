using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Runtime
{
	[SupportedBy("Chrome")]
	public class PropertyPreview
	{
		/// <summary>
		/// Property name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Object type. Accessor means that the property itself is an accessor property.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// User-friendly property value string.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Value { get; set; }
		/// <summary>
		/// Nested value preview.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ObjectPreview ValuePreview { get; set; }
		/// <summary>
		/// Object subtype hint. Specified for `object` type values only.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Subtype { get; set; }
	}
}
