using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CacheStorage
{
	/// <summary>
	/// Cache identifier.
	/// </summary>
	[SupportedBy("Chrome")]
	public class Cache
	{
		/// <summary>
		/// An opaque unique id of the cache.
		/// </summary>
		public string CacheId { get; set; }
		/// <summary>
		/// Security origin of the cache.
		/// </summary>
		public string SecurityOrigin { get; set; }
		/// <summary>
		/// Storage key of the cache.
		/// </summary>
		public string StorageKey { get; set; }
		/// <summary>
		/// The name of the cache.
		/// </summary>
		public string CacheName { get; set; }
	}
}
