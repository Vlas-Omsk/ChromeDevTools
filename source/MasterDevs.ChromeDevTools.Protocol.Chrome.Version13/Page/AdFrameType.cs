using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page{
	/// <summary>
	/// Indicates whether a frame has been identified as an ad.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AdFrameType
	{
			None,
			Child,
			Root,
	}
}
