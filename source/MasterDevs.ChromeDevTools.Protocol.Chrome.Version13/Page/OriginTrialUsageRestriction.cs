using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum OriginTrialUsageRestriction
	{
			None,
			Subset,
	}
}
