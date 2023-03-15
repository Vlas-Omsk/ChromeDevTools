using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Clears storage for storage key.
	/// </summary>
	[Command(ProtocolName.Storage.ClearDataForStorageKey)]
	[SupportedBy("Chrome")]
	public class ClearDataForStorageKeyCommand: IProtocolCommand<ClearDataForStorageKeyCommandResponse>
	{
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
