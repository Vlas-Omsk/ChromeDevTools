using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Network
{
	/// <summary>
	/// Clears browser cache.
	/// </summary>

	[SupportedBy("IOS")]
	public class ClearBrowserCacheCommand: ICommand<ClearBrowserCacheCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.ClearBrowserCache;
	}
}
