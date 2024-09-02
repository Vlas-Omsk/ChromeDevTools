using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Profiler
{
	/// <summary>
	/// Changes CPU profiler sampling interval. Must be called before CPU profiles recording started.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetSamplingIntervalCommandParams: ICommandParams<SetSamplingIntervalCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Profiler.SetSamplingInterval;
		/// <summary>
		/// New sampling interval in microseconds.
		/// </summary>
		public long Interval { get; set; }
	}
}
