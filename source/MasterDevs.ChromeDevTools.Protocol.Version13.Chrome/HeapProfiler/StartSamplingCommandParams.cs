using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.HeapProfiler
{

	[SupportedBy("Chrome")]
	public class StartSamplingCommandParams: ICommandParams<StartSamplingCommandResult>
	{
		public string MethodName { get; } = ProtocolName.HeapProfiler.StartSampling;
		/// <summary>
		/// Average sample interval in bytes. Poisson distribution is used for the intervals. The
		/// default value is 32768 bytes.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double SamplingInterval { get; set; }
		/// <summary>
		/// By default, the sampling heap profiler reports only objects which are
		/// still alive when the profile is returned via getSamplingProfile or
		/// stopSampling, which is useful for determining what functions contribute
		/// the most to steady-state memory usage. This flag instructs the sampling
		/// heap profiler to also include information about objects discarded by
		/// major GC, which will show which functions cause large temporary memory
		/// usage or long GC pauses.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IncludeObjectsCollectedByMajorGC { get; set; }
		/// <summary>
		/// By default, the sampling heap profiler reports only objects which are
		/// still alive when the profile is returned via getSamplingProfile or
		/// stopSampling, which is useful for determining what functions contribute
		/// the most to steady-state memory usage. This flag instructs the sampling
		/// heap profiler to also include information about objects discarded by
		/// minor GC, which is useful when tuning a latency-sensitive application
		/// for minimal GC activity.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IncludeObjectsCollectedByMinorGC { get; set; }
	}
}
