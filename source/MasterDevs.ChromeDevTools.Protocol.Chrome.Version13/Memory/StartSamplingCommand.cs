using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Memory
{
	/// <summary>
	/// Start collecting native memory profile.
	/// </summary>

	[SupportedBy("Chrome")]
	public class StartSamplingCommand: ICommand<StartSamplingCommandResult>
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
