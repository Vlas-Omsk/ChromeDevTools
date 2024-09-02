using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Memory
{
	/// <summary>
	/// Heap profile sample.
	/// </summary>
	[SupportedBy("Chrome")]
	public class SamplingProfileNode
	{
		/// <summary>
		/// Size of the sampled allocation.
		/// </summary>
		public double Size { get; set; }
		/// <summary>
		/// Total bytes attributed to this sample.
		/// </summary>
		public double Total { get; set; }
		/// <summary>
		/// Execution stack at the point of allocation.
		/// </summary>
		public string[] Stack { get; set; }
	}
}
