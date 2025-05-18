using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Network{
	/// <summary>
	/// Types of reasons why a cookie may not be stored from a response.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SetCookieBlockedReason
	{
			SecureOnly,
			SameSiteStrict,
			SameSiteLax,
			SameSiteUnspecifiedTreatedAsLax,
			SameSiteNoneInsecure,
			UserPreferences,
			ThirdPartyBlockedInFirstPartySet,
			SyntaxError,
			SchemeNotSupported,
			OverwriteSecure,
			InvalidDomain,
			InvalidPrefix,
			UnknownError,
			SchemefulSameSiteStrict,
			SchemefulSameSiteLax,
			SchemefulSameSiteUnspecifiedTreatedAsLax,
			SamePartyFromCrossPartyContext,
			SamePartyConflictsWithOtherAttributes,
			NameValuePairExceedsMaxSize,
	}
}
