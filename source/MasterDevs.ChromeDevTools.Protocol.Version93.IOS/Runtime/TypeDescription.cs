using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Runtime
{
	/// <summary>
	/// Container for type information that has been gathered.
	/// </summary>
	[SupportedBy("IOS")]
	public class TypeDescription
	{
		/// <summary>
		/// If true, we were able to correlate the offset successfuly with a program location. If false, the offset may be bogus or the offset may be from a CodeBlock that hasn't executed.
		/// </summary>
		public bool IsValid { get; set; }
		/// <summary>
		/// Least common ancestor of all Constructors if the TypeDescription has seen any structures. This string is the display name of the shared constructor function.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string LeastCommonAncestor { get; set; }
		/// <summary>
		/// Set of booleans for determining the aggregate type of this type description.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public TypeSet TypeSet { get; set; }
		/// <summary>
		/// Array of descriptions for all structures seen for this variable.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public StructureDescription[] Structures { get; set; }
		/// <summary>
		/// If true, this indicates that no more structures are being profiled because some maximum threshold has been reached and profiling has stopped because of memory pressure.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IsTruncated { get; set; }
	}
}
