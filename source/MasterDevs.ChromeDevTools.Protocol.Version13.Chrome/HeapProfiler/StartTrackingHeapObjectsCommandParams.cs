using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.HeapProfiler
{

	[SupportedBy("Chrome")]
	public class StartTrackingHeapObjectsCommandParams: ICommandParams<StartTrackingHeapObjectsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.HeapProfiler.StartTrackingHeapObjects;
		/// <summary>
		/// TrackAllocations
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? TrackAllocations { get; set; }
	}
}
