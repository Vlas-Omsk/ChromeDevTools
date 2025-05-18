using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.IndexedDB
{
	/// <summary>
	/// Clears all entries from an object store.
	/// </summary>

	[SupportedBy("IOS")]
	public class ClearObjectStoreCommand: ICommand<ClearObjectStoreCommandResult>
	{
		public string MethodName { get; } = ProtocolName.IndexedDB.ClearObjectStore;
		/// <summary>
		/// Security origin.
		/// </summary>
		public string SecurityOrigin { get; set; }
		/// <summary>
		/// Database name.
		/// </summary>
		public string DatabaseName { get; set; }
		/// <summary>
		/// Object store name.
		/// </summary>
		public string ObjectStoreName { get; set; }
	}
}
