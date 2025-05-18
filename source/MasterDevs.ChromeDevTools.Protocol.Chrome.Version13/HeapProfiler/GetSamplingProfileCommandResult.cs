using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.HeapProfiler
{

	[SupportedBy("Chrome")]
	public class GetSamplingProfileCommandResult : ICommandResult
	{
		/// <summary>
		/// Return the sampling profile being collected.
		/// </summary>
		public SamplingHeapProfile Profile { get; set; }
	}
}
