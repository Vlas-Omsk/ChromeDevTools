using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CacheStorage
{
	/// <summary>
	/// Deletes a cache.
	/// </summary>
	[Command(ProtocolName.CacheStorage.DeleteCache)]
	[SupportedBy("Chrome")]
	public class DeleteCacheCommand: IProtocolCommand<DeleteCacheCommandResponse>
	{
		/// <summary>
		/// Id of cache for deletion.
		/// </summary>
		public string CacheId { get; set; }
	}
}
