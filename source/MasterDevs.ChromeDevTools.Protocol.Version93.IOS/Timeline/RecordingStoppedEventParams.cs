using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Timeline
{
	/// <summary>
	/// Fired when recording has stopped.
	/// </summary>
	[EventName(ProtocolName.Timeline.RecordingStopped)]
	[SupportedBy("IOS")]
	public class RecordingStoppedEventParams : IEventParams
	{
		/// <summary>
		/// End time of this recording.
		/// </summary>
		public double EndTime { get; set; }
	}
}
