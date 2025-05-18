using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Storage
{
	/// <summary>
	/// Unregisters storage key from receiving notifications for cache storage.
	/// </summary>

	[SupportedBy("Chrome")]
	public class UntrackCacheStorageForStorageKeyCommand: ICommand<UntrackCacheStorageForStorageKeyCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Storage.UntrackCacheStorageForStorageKey;
		/// <summary>
		/// Storage key.
		/// </summary>
		public string StorageKey { get; set; }
	}
}
