using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.IndexedDB
{
	/// <summary>
	/// Clears all entries from an object store.
	/// </summary>
	[Command(ProtocolName.IndexedDB.ClearObjectStore)]
	[SupportedBy("iOS")]
	public class ClearObjectStoreCommand: IProtocolCommand<ClearObjectStoreCommandResponse>
	{
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
