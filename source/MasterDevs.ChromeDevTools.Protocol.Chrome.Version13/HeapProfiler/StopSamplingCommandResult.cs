using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.HeapProfiler
{

	[SupportedBy("Chrome")]
	public class StopSamplingCommandResult : ICommandResult
	{
		/// <summary>
		/// Recorded sampling heap profile.
		/// </summary>
		public SamplingHeapProfile Profile { get; set; }
	}
}
