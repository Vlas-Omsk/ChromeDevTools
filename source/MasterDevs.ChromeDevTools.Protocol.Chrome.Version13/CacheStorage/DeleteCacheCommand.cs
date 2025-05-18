using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.CacheStorage
{
	/// <summary>
	/// Deletes a cache.
	/// </summary>

	[SupportedBy("Chrome")]
	public class DeleteCacheCommand: ICommand<DeleteCacheCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CacheStorage.DeleteCache;
		/// <summary>
		/// Id of cache for deletion.
		/// </summary>
		public string CacheId { get; set; }
	}
}
