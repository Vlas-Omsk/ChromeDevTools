using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Memory{
	/// <summary>
	/// Memory pressure level.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PressureLevel
	{
			Moderate,
			Critical,
	}
}