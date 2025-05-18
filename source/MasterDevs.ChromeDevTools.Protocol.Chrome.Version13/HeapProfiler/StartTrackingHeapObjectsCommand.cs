using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.HeapProfiler
{

	[SupportedBy("Chrome")]
	public class StartTrackingHeapObjectsCommand: ICommand<StartTrackingHeapObjectsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.HeapProfiler.StartTrackingHeapObjects;
		/// <summary>
		/// TrackAllocations
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? TrackAllocations { get; set; }
	}
}
