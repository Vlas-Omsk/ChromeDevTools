using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.DOM{
	/// <summary>
	/// Token values of @aria-relevant attribute.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum LiveRegionRelevant
	{
			Additions,
			Removals,
			Text,
	}
}
