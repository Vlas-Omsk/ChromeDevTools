using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Page
{
	/// <summary>
	/// Cookie object
	/// </summary>
	[SupportedBy("IOS")]
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
		/// Cookie expires.
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
	}
}
