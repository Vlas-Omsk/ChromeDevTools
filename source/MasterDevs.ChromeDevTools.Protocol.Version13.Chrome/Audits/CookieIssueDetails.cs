using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Audits
{
	/// <summary>
	/// This information is currently necessary, as the front-end has a difficult
	/// time finding a specific cookie. With this, we can convey specific error
	/// information without the cookie.
	/// </summary>
	[SupportedBy("Chrome")]
	public class CookieIssueDetails
	{
		/// <summary>
		/// If AffectedCookie is not set then rawCookieLine contains the raw
		/// Set-Cookie header string. This hints at a problem where the
		/// cookie line is syntactically or semantically malformed in a way
		/// that no valid cookie could be created.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AffectedCookie Cookie { get; set; }
		/// <summary>
		/// RawCookieLine
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string RawCookieLine { get; set; }
		/// <summary>
		/// CookieWarningReasons
		/// </summary>
		public CookieWarningReason[] CookieWarningReasons { get; set; }
		/// <summary>
		/// CookieExclusionReasons
		/// </summary>
		public CookieExclusionReason[] CookieExclusionReasons { get; set; }
		/// <summary>
		/// Optionally identifies the site-for-cookies and the cookie url, which
		/// may be used by the front-end as additional context.
		/// </summary>
		public CookieOperation Operation { get; set; }
		/// <summary>
		/// SiteForCookies
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string SiteForCookies { get; set; }
		/// <summary>
		/// CookieUrl
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string CookieUrl { get; set; }
		/// <summary>
		/// Request
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AffectedRequest Request { get; set; }
	}
}
