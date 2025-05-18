using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Network{
	/// <summary>
	/// Source of serviceworker response.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ServiceWorkerResponseSource
	{
			[EnumMember(Value = "cache-storage")]
			Cache_storage,
			[EnumMember(Value = "http-cache")]
			Http_cache,
			[EnumMember(Value = "fallback-code")]
			Fallback_code,
			Network,
	}
}
