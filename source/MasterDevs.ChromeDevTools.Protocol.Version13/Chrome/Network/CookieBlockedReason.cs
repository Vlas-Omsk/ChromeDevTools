using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network{
	/// <summary>
	/// Types of reasons why a cookie may not be sent with a request.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CookieBlockedReason
	{
			SecureOnly,
			NotOnPath,
			DomainMismatch,
			SameSiteStrict,
			SameSiteLax,
			SameSiteUnspecifiedTreatedAsLax,
			SameSiteNoneInsecure,
			UserPreferences,
			ThirdPartyBlockedInFirstPartySet,
			UnknownError,
			SchemefulSameSiteStrict,
			SchemefulSameSiteLax,
			SchemefulSameSiteUnspecifiedTreatedAsLax,
			SamePartyFromCrossPartyContext,
			NameValuePairExceedsMaxSize,
	}
}
