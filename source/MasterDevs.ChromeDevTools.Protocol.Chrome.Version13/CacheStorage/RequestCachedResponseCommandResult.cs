using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.CacheStorage
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
