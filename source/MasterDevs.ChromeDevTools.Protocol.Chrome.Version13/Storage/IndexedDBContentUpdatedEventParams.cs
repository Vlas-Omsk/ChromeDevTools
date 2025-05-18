using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Storage
{
	/// <summary>
	/// The origin's IndexedDB object store has been modified.
	/// </summary>
	[EventName(ProtocolName.Storage.IndexedDBContentUpdated)]
	[SupportedBy("Chrome")]
	public class IndexedDBContentUpdatedEventParams : IEventParams
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
