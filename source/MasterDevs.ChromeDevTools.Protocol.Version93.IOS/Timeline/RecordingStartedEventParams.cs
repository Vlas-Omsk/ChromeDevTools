using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Timeline
{
	/// <summary>
	/// Fired when recording has started.
	/// </summary>
	[EventName(ProtocolName.Timeline.RecordingStarted)]
	[SupportedBy("IOS")]
	public class RecordingStartedEventParams : IEventParams
	{
		/// <summary>
		/// Start time of this new recording.
		/// </summary>
		public double StartTime { get; set; }
	}
}
