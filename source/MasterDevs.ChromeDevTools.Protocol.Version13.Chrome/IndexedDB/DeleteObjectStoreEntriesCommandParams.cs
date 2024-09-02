using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.IndexedDB
{
	/// <summary>
	/// Delete a range of entries from an object store
	/// </summary>

	[SupportedBy("Chrome")]
	public class DeleteObjectStoreEntriesCommandParams: ICommandParams<DeleteObjectStoreEntriesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.IndexedDB.DeleteObjectStoreEntries;
		/// <summary>
		/// At least and at most one of securityOrigin, storageKey must be specified.
		/// Security origin.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string SecurityOrigin { get; set; }
		/// <summary>
		/// Storage key.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string StorageKey { get; set; }
		/// <summary>
		/// DatabaseName
		/// </summary>
		public string DatabaseName { get; set; }
		/// <summary>
		/// ObjectStoreName
		/// </summary>
		public string ObjectStoreName { get; set; }
		/// <summary>
		/// Range of entry keys to delete
		/// </summary>
		public KeyRange KeyRange { get; set; }
	}
}
