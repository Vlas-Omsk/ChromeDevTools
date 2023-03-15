using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Profiler
{
	/// <summary>
	/// Profile.
	/// </summary>
	[SupportedBy("Chrome")]
	public class Profile
	{
		/// <summary>
		/// The list of profile nodes. First item is the root node.
		/// </summary>
		public ProfileNode[] Nodes { get; set; }
		/// <summary>
		/// Profiling start timestamp in microseconds.
		/// </summary>
		public double StartTime { get; set; }
		/// <summary>
		/// Profiling end timestamp in microseconds.
		/// </summary>
		public double EndTime { get; set; }
		/// <summary>
		/// Ids of samples top nodes.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long[] Samples { get; set; }
		/// <summary>
		/// Time intervals between adjacent samples in microseconds. The first delta is relative to the
		/// profile startTime.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long[] TimeDeltas { get; set; }
	}
}
