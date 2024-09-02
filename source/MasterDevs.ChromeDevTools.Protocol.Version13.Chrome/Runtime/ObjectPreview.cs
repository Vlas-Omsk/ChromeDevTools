using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Runtime
{
	/// <summary>
	/// Object containing abbreviated remote object value.
	/// </summary>
	[SupportedBy("Chrome")]
	public class ObjectPreview
	{
		/// <summary>
		/// Object type.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Object subtype hint. Specified for `object` type values only.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Subtype { get; set; }
		/// <summary>
		/// String representation of the object.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Description { get; set; }
		/// <summary>
		/// True iff some of the properties or entries of the original object did not fit.
		/// </summary>
		public bool Overflow { get; set; }
		/// <summary>
		/// List of the properties.
		/// </summary>
		public PropertyPreview[] Properties { get; set; }
		/// <summary>
		/// List of the entries. Specified for `map` and `set` subtype values only.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public EntryPreview[] Entries { get; set; }
	}
}
