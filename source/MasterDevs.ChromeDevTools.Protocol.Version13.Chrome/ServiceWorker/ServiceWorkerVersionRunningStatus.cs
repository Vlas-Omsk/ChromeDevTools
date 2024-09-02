using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.ServiceWorker{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ServiceWorkerVersionRunningStatus
	{
			Stopped,
			Starting,
			Running,
			Stopping,
	}
}
