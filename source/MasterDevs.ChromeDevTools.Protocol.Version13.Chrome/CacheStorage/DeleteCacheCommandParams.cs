using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CacheStorage
{
	/// <summary>
	/// Deletes a cache.
	/// </summary>

	[SupportedBy("Chrome")]
	public class DeleteCacheCommandParams: ICommandParams<DeleteCacheCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CacheStorage.DeleteCache;
		/// <summary>
		/// Id of cache for deletion.
		/// </summary>
		public string CacheId { get; set; }
	}
}
