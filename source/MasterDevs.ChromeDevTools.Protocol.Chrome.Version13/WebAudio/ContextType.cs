using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.WebAudio{
	/// <summary>
	/// Enum of BaseAudioContext types
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ContextType
	{
			Realtime,
			Offline,
	}
}
