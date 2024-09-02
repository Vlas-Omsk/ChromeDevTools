using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Worker
{
	[EventName(ProtocolName.Worker.WorkerTerminated)]
	[SupportedBy("IOS")]
	public class WorkerTerminatedEventParams : IEventParams
	{
		/// <summary>
		/// WorkerId
		/// </summary>
		public long WorkerId { get; set; }
	}
}
