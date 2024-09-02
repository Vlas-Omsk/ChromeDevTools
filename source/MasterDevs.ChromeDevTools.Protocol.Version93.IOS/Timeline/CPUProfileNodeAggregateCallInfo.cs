using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Timeline
{
	/// <summary>
	/// Aggregate CPU Profile call info. Holds time information for all the calls that happened on a node.
	/// </summary>
	[SupportedBy("IOS")]
	public class CPUProfileNodeAggregateCallInfo
	{
		/// <summary>
		/// Total number of calls.
		/// </summary>
		public double CallCount { get; set; }
		/// <summary>
		/// Start time for the first call.
		/// </summary>
		public double StartTime { get; set; }
		/// <summary>
		/// End time for the last call.
		/// </summary>
		public double EndTime { get; set; }
		/// <summary>
		/// Total execution time for all calls combined.
		/// </summary>
		public double TotalTime { get; set; }
	}
}
