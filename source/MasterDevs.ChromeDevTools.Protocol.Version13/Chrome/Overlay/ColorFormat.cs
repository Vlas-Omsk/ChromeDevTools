using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ColorFormat
	{
			Rgb,
			Hsl,
			Hwb,
			Hex,
	}
}
