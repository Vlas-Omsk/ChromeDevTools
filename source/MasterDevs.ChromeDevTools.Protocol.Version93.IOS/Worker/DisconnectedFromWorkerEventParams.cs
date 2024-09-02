using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Worker
{
	[EventName(ProtocolName.Worker.DisconnectedFromWorker)]
	[SupportedBy("IOS")]
	public class DisconnectedFromWorkerEventParams : IEventParams
	{
	}
}
