using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.HeapProfiler
{
	/// <summary>
	/// Sampling profile.
	/// </summary>
	[SupportedBy("Chrome")]
	public class SamplingHeapProfile
	{
		/// <summary>
		/// Head
		/// </summary>
		public SamplingHeapProfileNode Head { get; set; }
		/// <summary>
		/// Samples
		/// </summary>
		public SamplingHeapProfileSample[] Samples { get; set; }
	}
}
