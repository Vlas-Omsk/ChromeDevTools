using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.CacheStorage{
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
