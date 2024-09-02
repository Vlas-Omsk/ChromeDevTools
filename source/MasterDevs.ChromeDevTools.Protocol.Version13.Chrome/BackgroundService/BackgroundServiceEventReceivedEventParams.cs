using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.BackgroundService
{
	/// <summary>
	/// Called with all existing backgroundServiceEvents when enabled, and all new
	/// events afterwards if enabled and recording.
	/// </summary>
	[EventName(ProtocolName.BackgroundService.BackgroundServiceEventReceived)]
	[SupportedBy("Chrome")]
	public class BackgroundServiceEventReceivedEventParams : IEventParams
	{
		/// <summary>
		/// BackgroundServiceEvent
		/// </summary>
		public BackgroundServiceEvent BackgroundServiceEvent { get; set; }
	}
}
