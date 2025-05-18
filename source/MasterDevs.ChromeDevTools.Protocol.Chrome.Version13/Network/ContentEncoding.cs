using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Network{
	/// <summary>
	/// List of content encodings supported by the backend.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ContentEncoding
	{
			Deflate,
			Gzip,
			Br,
	}
}
