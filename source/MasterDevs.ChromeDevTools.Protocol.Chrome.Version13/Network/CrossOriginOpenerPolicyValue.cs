using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Network{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CrossOriginOpenerPolicyValue
	{
			SameOrigin,
			SameOriginAllowPopups,
			RestrictProperties,
			UnsafeNone,
			SameOriginPlusCoep,
			RestrictPropertiesPlusCoep,
	}
}
