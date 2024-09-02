using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Worker
{
	[EventName(ProtocolName.Worker.DispatchMessageFromWorker)]
	[SupportedBy("IOS")]
	public class DispatchMessageFromWorkerEventParams : IEventParams
	{
		/// <summary>
		/// WorkerId
		/// </summary>
		public long WorkerId { get; set; }
		/// <summary>
		/// Message
		/// </summary>
		public object Message { get; set; }
	}
}
