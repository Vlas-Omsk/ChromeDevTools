using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Network{
	/// <summary>
	/// The reason why request was blocked.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CorsError
	{
			DisallowedByMode,
			InvalidResponse,
			WildcardOriginNotAllowed,
			MissingAllowOriginHeader,
			MultipleAllowOriginValues,
			InvalidAllowOriginValue,
			AllowOriginMismatch,
			InvalidAllowCredentials,
			CorsDisabledScheme,
			PreflightInvalidStatus,
			PreflightDisallowedRedirect,
			PreflightWildcardOriginNotAllowed,
			PreflightMissingAllowOriginHeader,
			PreflightMultipleAllowOriginValues,
			PreflightInvalidAllowOriginValue,
			PreflightAllowOriginMismatch,
			PreflightInvalidAllowCredentials,
			PreflightMissingAllowExternal,
			PreflightInvalidAllowExternal,
			PreflightMissingAllowPrivateNetwork,
			PreflightInvalidAllowPrivateNetwork,
			InvalidAllowMethodsPreflightResponse,
			InvalidAllowHeadersPreflightResponse,
			MethodDisallowedByPreflightResponse,
			HeaderDisallowedByPreflightResponse,
			RedirectContainsCredentials,
			InsecurePrivateNetwork,
			InvalidPrivateNetworkAccess,
			UnexpectedPrivateNetworkAccess,
			NoCorsRedirectModeNotFollow,
	}
}
