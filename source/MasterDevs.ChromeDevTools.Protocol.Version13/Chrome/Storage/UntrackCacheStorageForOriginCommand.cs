using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Unregisters origin from receiving notifications for cache storage.
	/// </summary>
	[Command(ProtocolName.Storage.UntrackCacheStorageForOrigin)]
	[SupportedBy("Chrome")]
	public class UntrackCacheStorageForOriginCommand: IProtocolCommand<UntrackCacheStorageForOriginCommandResponse>
	{
		/// <summary>
		/// Security origin.
		/// </summary>
		public string Origin { get; set; }
	}
}
