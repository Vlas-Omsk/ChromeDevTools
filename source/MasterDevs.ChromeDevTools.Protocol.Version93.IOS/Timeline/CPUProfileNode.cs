using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Timeline
{
	/// <summary>
	/// CPU Profile node. Holds callsite information, execution statistics and child nodes.
	/// </summary>
	[SupportedBy("IOS")]
	public class CPUProfileNode
	{
		/// <summary>
		/// Unique identifier for this call site.
		/// </summary>
		public long Id { get; set; }
		/// <summary>
		/// Aggregate info about all the calls that making up this node.
		/// </summary>
		public CPUProfileNodeAggregateCallInfo CallInfo { get; set; }
		/// <summary>
		/// Function name.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string FunctionName { get; set; }
		/// <summary>
		/// URL.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Url { get; set; }
		/// <summary>
		/// Line number.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? LineNumber { get; set; }
		/// <summary>
		/// Column number.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ColumnNumber { get; set; }
		/// <summary>
		/// Child nodes.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CPUProfileNode[] Children { get; set; }
	}
}
