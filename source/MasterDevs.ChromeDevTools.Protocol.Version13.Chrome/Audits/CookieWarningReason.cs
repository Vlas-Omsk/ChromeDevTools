using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Audits{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CookieWarningReason
	{
			WarnSameSiteUnspecifiedCrossSiteContext,
			WarnSameSiteNoneInsecure,
			WarnSameSiteUnspecifiedLaxAllowUnsafe,
			WarnSameSiteStrictLaxDowngradeStrict,
			WarnSameSiteStrictCrossDowngradeStrict,
			WarnSameSiteStrictCrossDowngradeLax,
			WarnSameSiteLaxCrossDowngradeStrict,
			WarnSameSiteLaxCrossDowngradeLax,
			WarnAttributeValueExceedsMaxSize,
			WarnDomainNonASCII,
	}
}
