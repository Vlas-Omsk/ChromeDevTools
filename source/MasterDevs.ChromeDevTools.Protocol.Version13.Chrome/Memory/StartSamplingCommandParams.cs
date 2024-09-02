using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Memory
{
	/// <summary>
	/// Start collecting native memory profile.
	/// </summary>

	[SupportedBy("Chrome")]
	public class StartSamplingCommandParams: ICommandParams<StartSamplingCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Memory.StartSampling;
		/// <summary>
		/// Average number of bytes between samples.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? SamplingInterval { get; set; }
		/// <summary>
		/// Do not randomize intervals between samples.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? SuppressRandomness { get; set; }
	}
}
