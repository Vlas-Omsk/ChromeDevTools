using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Network
{
	/// <summary>
	/// Clears browser cache.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ClearBrowserCacheCommand: ICommand<ClearBrowserCacheCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.ClearBrowserCache;
	}
}
