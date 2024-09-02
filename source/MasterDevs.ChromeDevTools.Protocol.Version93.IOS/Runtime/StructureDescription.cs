using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Runtime
{
	[SupportedBy("IOS")]
	public class StructureDescription
	{
		/// <summary>
		/// Array of strings, where the strings represent object properties.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] Fields { get; set; }
		/// <summary>
		/// Array of strings, where the strings represent optional object properties.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] OptionalFields { get; set; }
		/// <summary>
		/// Name of the constructor.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ConstructorName { get; set; }
		/// <summary>
		/// Pointer to the StructureRepresentation of the protoype if one exists.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public StructureDescription PrototypeStructure { get; set; }
		/// <summary>
		/// If true, it indicates that the fields in this StructureDescription may be inaccurate. I.e, there might have been fields that have been deleted before it was profiled or it has fields we haven't profiled.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IsImprecise { get; set; }
	}
}
