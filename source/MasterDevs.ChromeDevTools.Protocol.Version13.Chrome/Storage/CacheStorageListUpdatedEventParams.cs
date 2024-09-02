using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Storage
{
	/// <summary>
	/// A cache has been added/deleted.
	/// </summary>
	[EventName(ProtocolName.Storage.CacheStorageListUpdated)]
	[SupportedBy("Chrome")]
	public class CacheStorageListUpdatedEventParams : IEventParams
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
