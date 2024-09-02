using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Tracing
{
	/// <summary>
	/// Contains a bucket of collected trace events. When tracing is stopped collected events will be
	/// sent as a sequence of dataCollected events followed by tracingComplete event.
	/// </summary>
	[EventName(ProtocolName.Tracing.DataCollected)]
	[SupportedBy("Chrome")]
	public class DataCollectedEventParams : IEventParams
	{
		public class ValueArray
		{
		}

		/// <summary>
		/// Value
		/// </summary>
		public ValueArray[] Value { get; set; }
	}
}
