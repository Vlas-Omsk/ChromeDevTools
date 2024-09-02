using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Storage
{
	/// <summary>
	/// Unregisters origin from receiving notifications for cache storage.
	/// </summary>

	[SupportedBy("Chrome")]
	public class UntrackCacheStorageForOriginCommandParams: ICommandParams<UntrackCacheStorageForOriginCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Storage.UntrackCacheStorageForOrigin;
		/// <summary>
		/// Security origin.
		/// </summary>
		public string Origin { get; set; }
	}
}
