using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Profiler
{
	/// <summary>
	/// Profile node. Holds callsite information, execution statistics and child nodes.
	/// </summary>
	[SupportedBy("Chrome")]
	public class ProfileNode
	{
		/// <summary>
		/// Unique id of the node.
		/// </summary>
		public long Id { get; set; }
		/// <summary>
		/// Function location.
		/// </summary>
		public Runtime.CallFrame CallFrame { get; set; }
		/// <summary>
		/// Number of samples where this node was on top of the call stack.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? HitCount { get; set; }
		/// <summary>
		/// Child node ids.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long[] Children { get; set; }
		/// <summary>
		/// The reason of being not optimized. The function may be deoptimized or marked as don't
		/// optimize.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string DeoptReason { get; set; }
		/// <summary>
		/// An array of source position ticks.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public PositionTickInfo[] PositionTicks { get; set; }
	}
}
