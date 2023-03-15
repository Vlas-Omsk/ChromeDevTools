using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// The origin's IndexedDB object store has been modified.
	/// </summary>
	[Event(ProtocolName.Storage.IndexedDBContentUpdated)]
	[SupportedBy("Chrome")]
	public class IndexedDBContentUpdatedEvent
	{
		/// <summary>
		/// Origin to update.
		/// </summary>
		public string Origin { get; set; }
		/// <summary>
		/// Storage key to update.
		/// </summary>
		public string StorageKey { get; set; }
		/// <summary>
		/// Database to update.
		/// </summary>
		public string DatabaseName { get; set; }
		/// <summary>
		/// ObjectStore to update.
		/// </summary>
		public string ObjectStoreName { get; set; }
	}
}
