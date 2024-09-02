using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Network
{
	/// <summary>
	/// Clears browser cache.
	/// </summary>

	[SupportedBy("IOS")]
	public class ClearBrowserCacheCommandParams: ICommandParams<ClearBrowserCacheCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.ClearBrowserCache;
	}
}
