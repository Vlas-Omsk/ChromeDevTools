using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Security{
	/// <summary>
	/// The security level of a page or resource.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SecurityState
	{
			Unknown,
			Neutral,
			Insecure,
			Secure,
			Info,
			[EnumMember(Value = "insecure-broken")]
			Insecure_broken,
	}
}
