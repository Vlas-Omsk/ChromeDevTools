using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Network
{
	/// <summary>
	/// Toggles ignoring cache for each request. If <code>true</code>, cache will not be used.
	/// </summary>

	[SupportedBy("IOS")]
	public class SetCacheDisabledCommand: ICommand<SetCacheDisabledCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.SetCacheDisabled;
		/// <summary>
		/// Cache disabled state.
		/// </summary>
		public bool CacheDisabled { get; set; }
	}
}
