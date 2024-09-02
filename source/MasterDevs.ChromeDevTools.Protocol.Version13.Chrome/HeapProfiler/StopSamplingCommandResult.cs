using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.HeapProfiler
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
