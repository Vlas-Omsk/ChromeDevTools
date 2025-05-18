using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.ServiceWorker{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ServiceWorkerVersionStatus
	{
			New,
			Installing,
			Installed,
			Activating,
			Activated,
			Redundant,
	}
}
