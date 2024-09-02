using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Input{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum MouseButton
	{
			None,
			Left,
			Middle,
			Right,
			Back,
			Forward,
	}
}
