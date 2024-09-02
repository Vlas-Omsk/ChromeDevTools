using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Emulation
{
	/// <summary>
	/// Turns on virtual time for all frames (replacing real-time with a synthetic time source) and sets
	/// the current virtual time policy.  Note this supersedes any previous time budget.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetVirtualTimePolicyCommandParams: ICommandParams<SetVirtualTimePolicyCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Emulation.SetVirtualTimePolicy;
		/// <summary>
		/// Policy
		/// </summary>
		public string Policy { get; set; }
		/// <summary>
		/// If set, after this many virtual milliseconds have elapsed virtual time will be paused and a
		/// virtualTimeBudgetExpired event is sent.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Budget { get; set; }
		/// <summary>
		/// If set this specifies the maximum number of tasks that can be run before virtual is forced
		/// forwards to prevent deadlock.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? MaxVirtualTimeTaskStarvationCount { get; set; }
		/// <summary>
		/// If set, base::Time::Now will be overridden to initially return this value.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double InitialVirtualTime { get; set; }
	}
}
