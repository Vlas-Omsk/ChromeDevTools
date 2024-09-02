using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Network
{
	/// <summary>
	/// Toggles ignoring cache for each request. If <code>true</code>, cache will not be used.
	/// </summary>

	[SupportedBy("IOS")]
	public class SetCacheDisabledCommandParams: ICommandParams<SetCacheDisabledCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.SetCacheDisabled;
		/// <summary>
		/// Cache disabled state.
		/// </summary>
		public bool CacheDisabled { get; set; }
	}
}
