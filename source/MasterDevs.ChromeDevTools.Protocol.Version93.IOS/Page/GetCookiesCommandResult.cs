using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Page
{
	/// <summary>
	/// Returns all browser cookies. Depending on the backend support, will return detailed cookie information in the <code>cookies</code> field.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetCookiesCommandResult : ICommandResult
	{
		/// <summary>
		/// Array of cookie objects.
		/// </summary>
		public Cookie[] Cookies { get; set; }
	}
}
