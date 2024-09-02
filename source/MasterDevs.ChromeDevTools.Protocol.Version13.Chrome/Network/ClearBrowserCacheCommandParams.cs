using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Clears browser cache.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ClearBrowserCacheCommandParams: ICommandParams<ClearBrowserCacheCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.ClearBrowserCache;
	}
}
