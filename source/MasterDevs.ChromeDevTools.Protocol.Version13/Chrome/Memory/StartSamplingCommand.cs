using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Memory
{
	/// <summary>
	/// Start collecting native memory profile.
	/// </summary>
	[Command(ProtocolName.Memory.StartSampling)]
	[SupportedBy("Chrome")]
	public class StartSamplingCommand: IProtocolCommand<StartSamplingCommandResponse>
	{
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
