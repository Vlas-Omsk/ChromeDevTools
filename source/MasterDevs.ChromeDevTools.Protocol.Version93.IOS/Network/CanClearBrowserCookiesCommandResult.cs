using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Network
{
	/// <summary>
	/// Tells whether clearing browser cookies is supported.
	/// </summary>

	[SupportedBy("IOS")]
	public class CanClearBrowserCookiesCommandResult : ICommandResult
	{
		/// <summary>
		/// True if browser cookies can be cleared.
		/// </summary>
		public bool Result { get; set; }
	}
}
