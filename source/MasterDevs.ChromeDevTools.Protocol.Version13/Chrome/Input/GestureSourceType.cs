using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Input{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum GestureSourceType
	{
			Default,
			Touch,
			Mouse,
	}
}
