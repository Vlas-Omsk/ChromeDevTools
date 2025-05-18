using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Storage
{
	/// <summary>
	/// Returns all browser cookies.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetCookiesCommandResult : ICommandResult
	{
		/// <summary>
		/// Array of cookie objects.
		/// </summary>
		public Network.Cookie[] Cookies { get; set; }
	}
}
