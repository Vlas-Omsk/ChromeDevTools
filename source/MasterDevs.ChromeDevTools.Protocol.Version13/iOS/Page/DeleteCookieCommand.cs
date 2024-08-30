using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Deletes browser cookie with given name, domain and path.
	/// </summary>
	[Command(ProtocolName.Page.DeleteCookie)]
	[SupportedBy("iOS")]
	public class DeleteCookieCommand: ICommandParams<DeleteCookieCommandResponse>
	{
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
