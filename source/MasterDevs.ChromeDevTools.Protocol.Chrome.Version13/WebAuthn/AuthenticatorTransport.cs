using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.WebAuthn{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AuthenticatorTransport
	{
			Usb,
			Nfc,
			Ble,
			Cable,
			Internal,
	}
}
