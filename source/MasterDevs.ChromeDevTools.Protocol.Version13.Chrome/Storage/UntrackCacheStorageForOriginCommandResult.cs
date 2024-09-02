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
	public class UntrackCacheStorageForOriginCommandResult : ICommandResult
	{
	}
}
