using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Tracing
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
