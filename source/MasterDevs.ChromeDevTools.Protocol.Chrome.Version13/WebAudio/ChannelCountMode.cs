using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.WebAudio{
	/// <summary>
	/// Enum of AudioNode::ChannelCountMode from the spec
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ChannelCountMode
	{
			[EnumMember(Value = "clamped-max")]
			Clamped_max,
			Explicit,
			Max,
	}
}
