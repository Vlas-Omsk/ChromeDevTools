using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Tells whether emulation of network conditions is supported.
	/// </summary>
	[Obsolete]

	[SupportedBy("Chrome")]
	public class CanEmulateNetworkConditionsCommandParams: ICommandParams<CanEmulateNetworkConditionsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.CanEmulateNetworkConditions;
	}
}
