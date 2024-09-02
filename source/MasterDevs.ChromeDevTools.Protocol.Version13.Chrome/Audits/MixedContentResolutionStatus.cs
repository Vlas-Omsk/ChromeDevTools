using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Audits{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum MixedContentResolutionStatus
	{
			MixedContentBlocked,
			MixedContentAutomaticallyUpgraded,
			MixedContentWarning,
	}
}
