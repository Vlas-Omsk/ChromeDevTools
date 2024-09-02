using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CacheStorage{
	/// <summary>
	/// type of HTTP response cached
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CachedResponseType
	{
			Basic,
			Cors,
			Default,
			Error,
			OpaqueResponse,
			OpaqueRedirect,
	}
}
