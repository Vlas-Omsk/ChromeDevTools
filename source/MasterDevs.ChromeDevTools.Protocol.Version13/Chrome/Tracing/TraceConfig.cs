using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Tracing
{
	[SupportedBy("Chrome")]
	public class TraceConfig
	{
		/// <summary>
		/// Controls how the trace buffer stores data.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string RecordMode { get; set; }
		/// <summary>
		/// Size of the trace buffer in kilobytes. If not specified or zero is passed, a default value
		/// of 200 MB would be used.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double TraceBufferSizeInKb { get; set; }
		/// <summary>
		/// Turns on JavaScript stack sampling.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? EnableSampling { get; set; }
		/// <summary>
		/// Turns on system tracing.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? EnableSystrace { get; set; }
		/// <summary>
		/// Turns on argument filter.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? EnableArgumentFilter { get; set; }
		/// <summary>
		/// Included category filters.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] IncludedCategories { get; set; }
		/// <summary>
		/// Excluded category filters.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] ExcludedCategories { get; set; }
		/// <summary>
		/// Configuration to synthesize the delays in tracing.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] SyntheticDelays { get; set; }
		/// <summary>
		/// Configuration for memory dump triggers. Used only when "memory-infra" category is enabled.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public object MemoryDumpConfig { get; set; }
	}
}
