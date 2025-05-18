using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.SystemInfo{
	/// <summary>
	/// Image format of a given image.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ImageType
	{
			Jpeg,
			Webp,
			Unknown,
	}
}
