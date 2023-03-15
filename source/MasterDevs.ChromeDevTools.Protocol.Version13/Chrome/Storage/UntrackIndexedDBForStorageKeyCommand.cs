using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Unregisters storage key from receiving notifications for IndexedDB.
	/// </summary>
	[Command(ProtocolName.Storage.UntrackIndexedDBForStorageKey)]
	[SupportedBy("Chrome")]
	public class UntrackIndexedDBForStorageKeyCommand: IProtocolCommand<UntrackIndexedDBForStorageKeyCommandResponse>
	{
		/// <summary>
		/// Storage key.
		/// </summary>
		public string StorageKey { get; set; }
	}
}
