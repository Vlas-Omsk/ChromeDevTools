using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Tracing{
	/// <summary>
	/// Compression type to use for traces returned via streams.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum StreamCompression
	{
			None,
			Gzip,
	}
}
