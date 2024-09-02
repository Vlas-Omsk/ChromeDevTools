using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Storage
{
	/// <summary>
	/// Registers storage key to be notified when an update occurs to its cache storage list.
	/// </summary>

	[SupportedBy("Chrome")]
	public class TrackCacheStorageForStorageKeyCommandParams: ICommandParams<TrackCacheStorageForStorageKeyCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Storage.TrackCacheStorageForStorageKey;
		/// <summary>
		/// Storage key.
		/// </summary>
		public string StorageKey { get; set; }
	}
}
