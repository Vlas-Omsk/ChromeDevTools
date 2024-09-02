using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
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
