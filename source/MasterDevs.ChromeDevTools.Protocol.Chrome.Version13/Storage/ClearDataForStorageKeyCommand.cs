using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Storage
{
	/// <summary>
	/// Clears storage for storage key.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ClearDataForStorageKeyCommand: ICommand<ClearDataForStorageKeyCommandResult>
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
