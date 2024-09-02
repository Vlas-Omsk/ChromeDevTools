using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Storage
{
	/// <summary>
	/// The origin's IndexedDB database list has been modified.
	/// </summary>
	[EventName(ProtocolName.Storage.IndexedDBListUpdated)]
	[SupportedBy("Chrome")]
	public class IndexedDBListUpdatedEventParams : IEventParams
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
