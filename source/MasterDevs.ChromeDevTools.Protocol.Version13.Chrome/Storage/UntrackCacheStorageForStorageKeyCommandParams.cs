using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Storage
{
	/// <summary>
	/// Unregisters storage key from receiving notifications for cache storage.
	/// </summary>

	[SupportedBy("Chrome")]
	public class UntrackCacheStorageForStorageKeyCommandParams: ICommandParams<UntrackCacheStorageForStorageKeyCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Storage.UntrackCacheStorageForStorageKey;
		/// <summary>
		/// Storage key.
		/// </summary>
		public string StorageKey { get; set; }
	}
}
