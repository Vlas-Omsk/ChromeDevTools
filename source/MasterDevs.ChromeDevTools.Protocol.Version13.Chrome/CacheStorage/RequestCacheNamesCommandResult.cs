using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CacheStorage
{
	/// <summary>
	/// Requests cache names.
	/// </summary>

	[SupportedBy("Chrome")]
	public class RequestCacheNamesCommandResult : ICommandResult
	{
		/// <summary>
		/// Caches for the security origin.
		/// </summary>
		public Cache[] Caches { get; set; }
	}
}
