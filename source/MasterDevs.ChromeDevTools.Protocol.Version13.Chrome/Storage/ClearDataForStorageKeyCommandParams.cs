using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Storage
{
	/// <summary>
	/// Clears storage for storage key.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ClearDataForStorageKeyCommandParams: ICommandParams<ClearDataForStorageKeyCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Storage.ClearDataForStorageKey;
		/// <summary>
		/// Storage key.
		/// </summary>
		public string StorageKey { get; set; }
		/// <summary>
		/// Comma separated list of StorageType to clear.
		/// </summary>
		public string StorageTypes { get; set; }
	}
}
