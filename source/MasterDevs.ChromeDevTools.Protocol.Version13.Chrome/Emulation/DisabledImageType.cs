using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Emulation{
	/// <summary>
	/// Enum of image types that can be disabled.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DisabledImageType
	{
			Avif,
			Webp,
	}
}
