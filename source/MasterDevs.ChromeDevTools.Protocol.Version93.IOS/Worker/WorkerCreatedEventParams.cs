using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Worker
{
	[EventName(ProtocolName.Worker.WorkerCreated)]
	[SupportedBy("IOS")]
	public class WorkerCreatedEventParams : IEventParams
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
