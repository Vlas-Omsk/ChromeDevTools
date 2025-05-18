using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Worker
{
	[EventName(ProtocolName.Worker.DisconnectedFromWorker)]
	[SupportedBy("IOS")]
	public class DisconnectedFromWorkerEventParams : IEventParams
	{
	}
}
