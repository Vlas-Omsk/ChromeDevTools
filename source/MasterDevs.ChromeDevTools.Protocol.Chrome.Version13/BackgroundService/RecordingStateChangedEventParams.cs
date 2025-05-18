using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.BackgroundService
{
	/// <summary>
	/// Called when the recording state for the service has been updated.
	/// </summary>
	[EventName(ProtocolName.BackgroundService.RecordingStateChanged)]
	[SupportedBy("Chrome")]
	public class RecordingStateChangedEventParams : IEventParams
	{
		/// <summary>
		/// IsRecording
		/// </summary>
		public bool IsRecording { get; set; }
		/// <summary>
		/// Service
		/// </summary>
		public ServiceName Service { get; set; }
	}
}
