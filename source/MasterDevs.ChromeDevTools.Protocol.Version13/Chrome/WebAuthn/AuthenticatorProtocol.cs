using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAuthn{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AuthenticatorProtocol
	{
			U2f,
			Ctap2,
	}
}
