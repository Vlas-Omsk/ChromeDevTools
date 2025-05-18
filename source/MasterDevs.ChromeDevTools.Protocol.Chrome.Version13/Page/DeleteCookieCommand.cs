using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page
{
	/// <summary>
	/// Deletes browser cookie with given name, domain and path.
	/// </summary>
	[Obsolete]

	[SupportedBy("Chrome")]
	public class DeleteCookieCommand: ICommand<DeleteCookieCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.DeleteCookie;
		/// <summary>
		/// Name of the cookie to remove.
		/// </summary>
		public string CookieName { get; set; }
		/// <summary>
		/// URL to match cooke domain and path.
		/// </summary>
		public string Url { get; set; }
	}
}
