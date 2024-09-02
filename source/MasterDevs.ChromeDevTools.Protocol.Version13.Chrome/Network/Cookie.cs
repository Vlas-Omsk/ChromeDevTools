using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Cookie object
	/// </summary>
	[SupportedBy("Chrome")]
	public class Cookie
	{
		/// <summary>
		/// Cookie name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Cookie value.
		/// </summary>
		public string Value { get; set; }
		/// <summary>
		/// Cookie domain.
		/// </summary>
		public string Domain { get; set; }
		/// <summary>
		/// Cookie path.
		/// </summary>
		public string Path { get; set; }
		/// <summary>
		/// Cookie expiration date as the number of seconds since the UNIX epoch.
		/// </summary>
		public double Expires { get; set; }
		/// <summary>
		/// Cookie size.
		/// </summary>
		public long Size { get; set; }
		/// <summary>
		/// True if cookie is http-only.
		/// </summary>
		public bool HttpOnly { get; set; }
		/// <summary>
		/// True if cookie is secure.
		/// </summary>
		public bool Secure { get; set; }
		/// <summary>
		/// True in case of session cookie.
		/// </summary>
		public bool Session { get; set; }
		/// <summary>
		/// Cookie SameSite type.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CookieSameSite SameSite { get; set; }
		/// <summary>
		/// Cookie Priority
		/// </summary>
		public CookiePriority Priority { get; set; }
		/// <summary>
		/// True if cookie is SameParty.
		/// </summary>
		public bool SameParty { get; set; }
		/// <summary>
		/// Cookie source scheme type.
		/// </summary>
		public CookieSourceScheme SourceScheme { get; set; }
		/// <summary>
		/// Cookie source port. Valid values are {-1, [1, 65535]}, -1 indicates an unspecified port.
		/// An unspecified port value allows protocol clients to emulate legacy cookie scope for the port.
		/// This is a temporary ability and it will be removed in the future.
		/// </summary>
		public long SourcePort { get; set; }
		/// <summary>
		/// Cookie partition key. The site of the top-level URL the browser was visiting at the start
		/// of the request to the endpoint that set the cookie.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string PartitionKey { get; set; }
		/// <summary>
		/// True if cookie partition key is opaque.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? PartitionKeyOpaque { get; set; }
	}
}
