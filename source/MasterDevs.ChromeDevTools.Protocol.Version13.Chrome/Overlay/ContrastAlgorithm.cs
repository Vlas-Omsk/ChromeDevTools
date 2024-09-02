using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Overlay{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ContrastAlgorithm
	{
			Aa,
			Aaa,
			Apca,
	}
}
