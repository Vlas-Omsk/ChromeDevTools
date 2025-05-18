using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Network
{
	/// <summary>
	/// Tells whether clearing browser cache is supported.
	/// </summary>
	[Obsolete]

	[SupportedBy("Chrome")]
	public class CanClearBrowserCacheCommandResult : ICommandResult
	{
		/// <summary>
		/// True if browser cache can be cleared.
		/// </summary>
		public bool Result { get; set; }
	}
}
