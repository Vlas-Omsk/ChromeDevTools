using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum TrustTokenOperationType
	{
			Issuance,
			Redemption,
			Signing,
	}
}
