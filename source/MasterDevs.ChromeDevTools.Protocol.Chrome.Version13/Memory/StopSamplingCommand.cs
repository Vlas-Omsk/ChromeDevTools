using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Memory
{
	/// <summary>
	/// Stop collecting native memory profile.
	/// </summary>

	[SupportedBy("Chrome")]
	public class StopSamplingCommand: ICommand<StopSamplingCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Memory.StopSampling;
	}
}
