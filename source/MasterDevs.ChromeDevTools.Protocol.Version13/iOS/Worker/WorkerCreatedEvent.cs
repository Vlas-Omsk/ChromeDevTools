using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Worker
{
	[Event(ProtocolName.Worker.WorkerCreated)]
	[SupportedBy("iOS")]
	public class WorkerCreatedEvent
	{
		/// <summary>
		/// WorkerId
		/// </summary>
		public long WorkerId { get; set; }
		/// <summary>
		/// Url
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// InspectorConnected
		/// </summary>
		public bool InspectorConnected { get; set; }
	}
}
