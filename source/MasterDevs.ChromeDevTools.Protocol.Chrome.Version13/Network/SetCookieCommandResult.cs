using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Network
{
	/// <summary>
	/// Sets a cookie with the given cookie data; may overwrite equivalent cookies if they exist.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetCookieCommandResult : ICommandResult
	{
		/// <summary>
		/// Always set to true. If an error occurs, the response indicates protocol error.
		/// </summary>
		public bool Success { get; set; }
	}
}
