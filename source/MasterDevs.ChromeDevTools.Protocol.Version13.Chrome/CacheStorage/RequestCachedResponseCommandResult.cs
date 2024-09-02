using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CacheStorage
{
	/// <summary>
	/// Fetches cache entry.
	/// </summary>

	[SupportedBy("Chrome")]
	public class RequestCachedResponseCommandResult : ICommandResult
	{
		/// <summary>
		/// Response read from the cache.
		/// </summary>
		public CachedResponse Response { get; set; }
	}
}
