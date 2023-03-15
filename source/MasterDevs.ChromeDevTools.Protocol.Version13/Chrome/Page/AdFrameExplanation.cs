using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AdFrameExplanation
	{
			ParentIsAd,
			CreatedByAdScript,
			MatchedBlockingRule,
	}
}
