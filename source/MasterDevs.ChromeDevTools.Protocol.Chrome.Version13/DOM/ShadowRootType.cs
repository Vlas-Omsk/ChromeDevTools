using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOM{
	/// <summary>
	/// Shadow root type.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ShadowRootType
	{
			[EnumMember(Value = "user-agent")]
			User_agent,
			Open,
			Closed,
	}
}
