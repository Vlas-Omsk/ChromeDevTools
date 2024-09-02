using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum IPAddressSpace
	{
			Local,
			Private,
			Public,
			Unknown,
	}
}
