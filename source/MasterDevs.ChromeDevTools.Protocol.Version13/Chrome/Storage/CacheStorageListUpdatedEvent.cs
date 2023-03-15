using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// A cache has been added/deleted.
	/// </summary>
	[Event(ProtocolName.Storage.CacheStorageListUpdated)]
	[SupportedBy("Chrome")]
	public class CacheStorageListUpdatedEvent
	{
		/// <summary>
		/// Origin to update.
		/// </summary>
		public string Origin { get; set; }
		/// <summary>
		/// Storage key to update.
		/// </summary>
		public string StorageKey { get; set; }
	}
}
