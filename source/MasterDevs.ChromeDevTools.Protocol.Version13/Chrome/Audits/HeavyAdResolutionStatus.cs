using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum HeavyAdResolutionStatus
	{
			HeavyAdBlocked,
			HeavyAdWarning,
	}
}
