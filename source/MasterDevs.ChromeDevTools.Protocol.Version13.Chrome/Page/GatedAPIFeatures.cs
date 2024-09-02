using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum GatedAPIFeatures
	{
			SharedArrayBuffers,
			SharedArrayBuffersTransferAllowed,
			PerformanceMeasureMemory,
			PerformanceProfile,
	}
}
