using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.WebAuthn{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum Ctap2Version
	{
			Ctap2_0,
			Ctap2_1,
	}
}
