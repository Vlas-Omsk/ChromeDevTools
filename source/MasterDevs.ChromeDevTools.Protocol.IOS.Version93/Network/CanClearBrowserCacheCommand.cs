using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Network
{
	/// <summary>
	/// Tells whether clearing browser cache is supported.
	/// </summary>

	[SupportedBy("IOS")]
	public class CanClearBrowserCacheCommand: ICommand<CanClearBrowserCacheCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.CanClearBrowserCache;
	}
}
